using Microsoft.Office.Tools.Ribbon;

namespace PowerPointAddIn
{
    public partial class Ribbon2
    {
        private void Ribbon2_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RibbonControlEventArgs e)
        {
            var myForm = new Form1();
            myForm.ShowDialog();
        }
    }
}
