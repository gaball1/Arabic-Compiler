using System;
using System.Collections.Generic;

namespace COMPILE_RPROJECT
{
    internal class Parser
    {
        private readonly Queue<Token> _tokens;
        private readonly List<string> _errors = new List<string>(); // List to store errors
        private Token CurrentToken => _tokens.Count > 0 ? _tokens.Peek() : null;

        public Parser(List<Token> tokens)
        {
            if (tokens == null || tokens.Count == 0)
            {
                throw new ArgumentException("Token list cannot be null or empty.", nameof(tokens));
            }

            _tokens = new Queue<Token>(tokens);
        }

        public List<string> Parse()
        {
            try
            {
                ParseProgram();

                if (_errors.Count == 0)
                {
                    _errors.Add("Code is syntactically valid.");
                }
            }
            catch (Exception ex)
            {
                _errors.Add($"Syntax Error: {ex.Message}");
            }

            return _errors;
        }

        private void ParseProgram()
        {
            ParseStatementList();
            if (CurrentToken != null)
            {
                AddError($"Unexpected token '{CurrentToken.Value}' at line {CurrentToken.Line}, column {CurrentToken.Column}. Unexpected content after program statement.");
            }
        }

        private void ParseStatementList()
        {
            while (CurrentToken != null && IsStatementStart(CurrentToken))
            {
                ParseStatement();
            }
        }

        private void ParseStatement()
        {
            try
            {
                if (MatchKeyword("متغير"))
                {
                    ParseDeclaration();
                }
                else if (MatchKeyword("إذا"))
                {
                    ParseIfStatement();
                }
                else if (MatchKeyword("طالما"))
                {
                    ParseWhileStatement();
                }
                else if (CurrentToken.Type == TokenType.IDENT)
                {
                    ParseAssignment();
                }
                else
                {
                    AddError($"Unexpected token '{CurrentToken.Value}' at line {CurrentToken.Line}, column {CurrentToken.Column}.");
                }
            }
            catch (Exception ex)
            {
                AddError(ex.Message);
            }
        }

        private void ParseDeclaration()
        {
            Match(TokenType.KEYWORD, "متغير");
            Match(TokenType.IDENT);
            Match(TokenType.ASSIGN);
            ParseExpression();
            Match(TokenType.SEMICOLON);
        }

        private void ParseAssignment()
        {
            Match(TokenType.IDENT);
            Match(TokenType.ASSIGN);
            ParseExpression();
            Match(TokenType.SEMICOLON);
        }

        private void ParseIfStatement()
        {
            Match(TokenType.KEYWORD, "إذا");
            Match(TokenType.LPAREN);
            ParseCondition();
            Match(TokenType.RPAREN);
            Match(TokenType.LBRACE);
            ParseStatementList();
            Match(TokenType.RBRACE);
        }

        private void ParseWhileStatement()
        {
            Match(TokenType.KEYWORD, "طالما");
            Match(TokenType.LPAREN);
            ParseCondition();
            Match(TokenType.RPAREN);
            Match(TokenType.LBRACE);
            ParseStatementList();
            Match(TokenType.RBRACE);
        }

        private void ParseCondition()
        {
            ParseExpression();
            if (CurrentToken == null || CurrentToken.Type != TokenType.RELATIONALOPERATOR)
            {
                AddError($"Expected operator in condition but found {CurrentToken?.Type ?? TokenType.ERROR} at line {CurrentToken?.Line}, column {CurrentToken?.Column}.");
            }
            else
            {
                Match(TokenType.RELATIONALOPERATOR);
                ParseExpression();
            }
        }

        private void ParseExpression()
        {
            ParseTerm();
            while (CurrentToken != null && (CurrentToken.Type == TokenType.OPERATOR))
            {
                _tokens.Dequeue();
                ParseTerm();
            }
        }

        private void ParseTerm()
        {
            if (CurrentToken?.Type == TokenType.NUM || CurrentToken?.Type == TokenType.IDENT || CurrentToken?.Type == TokenType.STRING)
            {
                _tokens.Dequeue();
            }
            else if (CurrentToken?.Type == TokenType.LPAREN)
            {
                _tokens.Dequeue();
                ParseExpression();
                Match(TokenType.RPAREN);
            }
            else
            {
                AddError($"Expected IDENT, NUM, STRING, or LPAREN but found {CurrentToken?.Type} at line {CurrentToken?.Line}, column {CurrentToken?.Column}.");
            }
        }

        private void Match(TokenType expectedType, string expectedValue = null)
        {
            if (CurrentToken == null)
            {
                AddError($"Unexpected end of input. Expected {expectedType}.");
                return;
            }

            if (CurrentToken.Type != expectedType || (expectedValue != null && CurrentToken.Value != expectedValue))
            {
                AddError($"Expected {expectedType} ({expectedValue}), but found {CurrentToken.Type} ({CurrentToken.Value}) at line {CurrentToken.Line}, column {CurrentToken.Column}.");
            }
            else
            {
                _tokens.Dequeue();
            }
        }

        private bool MatchKeyword(string keyword)
        {
            if (CurrentToken?.Type == TokenType.KEYWORD && CurrentToken.Value == keyword)
            {
                _tokens.Dequeue();
                return true;
            }
            return false;
        }

        private bool IsStatementStart(Token token)
        {
            return token.Type == TokenType.KEYWORD || token.Type == TokenType.IDENT;
        }

        private void AddError(string message)
        {
            _errors.Add(message);
        }
    }
}
