using System;
using System.Windows.Forms;

namespace WordAddIn2
{
    public partial class WordAddInForm : Form
    {
        public WordAddInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo World from VSTO!");
        }
    }
}
