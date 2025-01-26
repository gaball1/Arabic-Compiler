# Arabic Language Compiler

## Overview

The **Arabic Language Compiler** is a project aimed at building a compiler that understands and processes Arabic programming syntax. This compiler allows users to write code using Arabic keywords, variables, and expressions. The goal of this project is to provide an Arabic-language alternative for programming that can be used by Arabic-speaking developers.

The compiler includes a **Lexical Analyzer (Lexer)** that tokenizes the source code and a **Syntax Analyzer (Parser)** to check the validity of the code structure.

## Features

- **Lexical Analysis (Lexer):** 
  - Tokenizes Arabic keywords, variables, operators, and numbers.
  - Identifies errors in tokens and provides feedback.

- **Syntax Analysis (Parser):** 
  - Validates whether the structure of the code adheres to language rules.
  - Provides feedback on syntax errors, including line and column numbers.

- **Error Reporting:** 
  - Detailed error messages with line and column number where the error occurs.

- **Support for Arabic Variables and Expressions:**
  - Handles Arabic variable names, mathematical expressions, and operators.

- **Graphical User Interface (GUI):**
  - Built with **Windows Forms** for easy interaction.
  - Features an input text box, compile button, and areas to display the results of the lexical and syntax analysis.

## Keywords Supported

The following are some of the keywords supported in the compiler:

- `متغير` (variable)
- `إذا` (if)
- `طالما` (while)
- `اطبع` (print)

## Installation

### Prerequisites

Before running the compiler, ensure that you have the following installed:

- **.NET Framework** (For Windows Forms application)
- **Visual Studio** (Recommended IDE for building and running the project)

### Steps to Run the Project

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/gaball1/Arabic-Compiler.git
    ```

2. Open the solution file (`ArabicLanguageCompiler.sln`) in **Visual Studio**.

3. Build the solution to restore dependencies and compile the code.

4. Run the project using the **Start Debugging (F5)** option in Visual Studio.

## Usage

1. Open the application, and you will see an input field where you can enter Arabic code.
2. Click the **Compile** button to tokenize and parse the input code.
3. The **Lexical Analysis** result will show the tokens identified in the source code, along with their type and position (line, column).
4. The **Syntax Analysis** result will indicate whether the code is syntactically valid or if there are any errors.

## Example

### Input Code:


متغير x = 5 + 3 * 2;
Expected Output:
# Lexical Analysis (Tokens):

- KEYWORD: متغير (Line: 1, Column: 1)
- IDENT: x (Line: 1, Column: 5)
- ASSIGN: = (Line: 1, Column: 7)
- NUM: 5 (Line: 1, Column: 9)
- OPERATOR: + (Line: 1, Column: 11)
- NUM: 3 (Line: 1, Column: 13)
- OPERATOR: * (Line: 1, Column: 15)
- NUM: 2 (Line: 1, Column: 17)
- SEMICOLON: ؛ (Line: 1, Column: 18)

# Syntax Analysis:

Syntax is valid!
Contributing
Contributions are welcome! If you want to contribute to the project, follow these steps:

Fork the repository.
Create a new branch.
Make your changes.
Commit your changes and push to your fork.
Open a pull request with a clear description of the changes you made.
License
This project is open source and available under the MIT License.

