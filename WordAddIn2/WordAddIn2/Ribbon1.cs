using Microsoft.Office.Tools.Ribbon;

namespace WordAddIn2
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            var myForm = new WordAddInForm();
            myForm.Show();
        }
    }
}
