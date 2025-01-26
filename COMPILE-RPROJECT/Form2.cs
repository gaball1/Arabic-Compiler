using System.Collections.Generic;
using System.Windows.Forms;

namespace COMPILE_RPROJECT
{
    public partial class Form2 : Form
    {
        public Form2(List<string> errors)
        {
            InitializeComponent();
            errorListBox.Items.AddRange(errors.ToArray());
        }
    }
}
