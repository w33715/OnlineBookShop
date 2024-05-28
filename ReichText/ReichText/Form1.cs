namespace ReichText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            //FontDialog dlg = new FontDialog();
            //dlg.ShowDialog();
            fontDialog1.ShowDialog(this);
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void buttonClolr_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }
    }
}