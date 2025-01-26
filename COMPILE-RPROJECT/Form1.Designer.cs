namespace COMPILE_RPROJECT
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblParserOutput = new System.Windows.Forms.Label();
            this.txtCodeInput = new System.Windows.Forms.TextBox();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowErrors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParserOutput
            // 
            this.lblParserOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblParserOutput.AutoSize = true;
            this.lblParserOutput.BackColor = System.Drawing.Color.Purple;
            this.lblParserOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParserOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParserOutput.Location = new System.Drawing.Point(106, 485);
            this.lblParserOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParserOutput.Name = "lblParserOutput";
            this.lblParserOutput.Size = new System.Drawing.Size(147, 29);
            this.lblParserOutput.TabIndex = 0;
            this.lblParserOutput.Text = "Valid Or Not";
            // 
            // txtCodeInput
            // 
            this.txtCodeInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodeInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodeInput.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtCodeInput.Location = new System.Drawing.Point(28, 130);
            this.txtCodeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodeInput.Multiline = true;
            this.txtCodeInput.Name = "txtCodeInput";
            this.txtCodeInput.Size = new System.Drawing.Size(366, 227);
            this.txtCodeInput.TabIndex = 1;
            // 
            // dgvTokens
            // 
            this.dgvTokens.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvTokens.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Location = new System.Drawing.Point(544, 94);
            this.dgvTokens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.RowHeadersWidth = 51;
            this.dgvTokens.RowTemplate.Height = 26;
            this.dgvTokens.Size = new System.Drawing.Size(463, 420);
            this.dgvTokens.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(413, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Compil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowErrors
            // 
            this.btnShowErrors.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnShowErrors.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowErrors.Location = new System.Drawing.Point(111, 534);
            this.btnShowErrors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowErrors.Name = "btnShowErrors";
            this.btnShowErrors.Size = new System.Drawing.Size(136, 46);
            this.btnShowErrors.TabIndex = 6;
            this.btnShowErrors.Text = "Show Errors";
            this.btnShowErrors.UseVisualStyleBackColor = true;
            this.btnShowErrors.Click += new System.EventHandler(this.btnShowErrors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(539, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tokens";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 614);
            this.Controls.Add(this.btnShowErrors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTokens);
            this.Controls.Add(this.txtCodeInput);
            this.Controls.Add(this.lblParserOutput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lblParserOutput;
		private System.Windows.Forms.TextBox txtCodeInput;
		private System.Windows.Forms.DataGridView dgvTokens;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowErrors;

    }
}

