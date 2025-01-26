using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace COMPILE_RPROJECT
{
    public partial class Form1 : Form
    {
        private List<string> errorList = new List<string>();

        // Initialize components in the form
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the "Compile" button click
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string inputCode = txtCodeInput.Text.Trim(); // Assuming txtCodeInput is a TextBox for code input

                // Check if input code is empty
                if (string.IsNullOrEmpty(inputCode))
                {
                    MessageBox.Show("Please enter some code to compile.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tokenize the code using a Lexer
                Lexer lexer = new Lexer(inputCode);
                List<Token> tokens = lexer.Tokenize();

                // If no columns in the DataGridView, add the required columns
                if (dgvTokens.Columns.Count == 0)
                {
                    dgvTokens.Columns.Add("TokenType", "نوع التوكن");
                    dgvTokens.Columns.Add("TokenValue", "قيمة التوكن");
                    dgvTokens.Columns.Add("Line", "رقم السطر");
                    dgvTokens.Columns.Add("Column", "رقم العمود");
                }

                // Clear previous rows and add new ones for the tokens
                dgvTokens.Rows.Clear();
                foreach (var token in tokens)
                {
                    dgvTokens.Rows.Add(token.Type.ToString(), token.Value, token.Line, token.Column);
                }

                // Parse the tokens
                Parser parser = new Parser(tokens);
                errorList = parser.Parse(); // This should return a list of errors (if any)

                // Update the label to show whether the code is syntactically valid
                lblParserOutput.Text = errorList.Count == 0 ? "Code is syntactically valid." : "Code contains errors.";
                lblParserOutput.ForeColor = errorList.Count == 0 ? Color.Green : Color.Red;
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., parsing errors)
                lblParserOutput.Text = $"Error: {ex.Message}";
                lblParserOutput.ForeColor = Color.Red;
            }
        }

        // Event handler for showing errors in a new form
        private void btnShowErrors_Click(object sender, EventArgs e)
        {
            // Open a new form to show the list of errors
            Form2 errorForm = new Form2(errorList);
            errorForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
