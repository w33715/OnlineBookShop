using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace WordAddIn1
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show(Globals.ThisAddIn.Application.Version);
            DialogResult dialogResult = MessageBox.Show(Globals.ThisAddIn.Application.ActiveDocument.Name);
        }
    }
}
