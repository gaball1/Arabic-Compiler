namespace COMPILE_RPROJECT
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.errorListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // errorListBox
            // 
            this.errorListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.errorListBox.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.errorListBox.FormattingEnabled = true;
            this.errorListBox.ItemHeight = 22;
            this.errorListBox.Location = new System.Drawing.Point(12, 35);
            this.errorListBox.Name = "errorListBox";
            this.errorListBox.Size = new System.Drawing.Size(754, 378);
            this.errorListBox.TabIndex = 0;
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(778, 474);
            this.Controls.Add(this.errorListBox);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Errors";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox errorListBox;
    }
}
