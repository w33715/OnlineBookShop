using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SpreadsheetLight;
using Microsoft.Win32;

namespace Generating_Excel_Files
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void CreateFile(string filePath)
        {
            if(filePath!=String.Empty)
            {
                using (SLDocument Doc=new SLDocument())
                {

                  //  Doc.SetCellValue("A1", "Jamie");
                    for (int i = 1; i < 11; i++)
                    {
                        Doc.SetCellValue($"B{i}", $"item {i}");
                        Doc.SetCellValue($"C{i}", i * 2);
                    }
 var table = Doc.CreateTable("A", "C10");
                    Doc.SetCellValue("C13", "=SUM(C1:C10)");
                   
                    table.SetTableStyle(SLTableStyleTypeValues.Medium15);
                    Doc.InsertTable(table);

                    Doc.SaveAs(filePath);
                }

               
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "xlsx";

            if(saveFile.ShowDialog()==true)
            {
                CreateFile(saveFile.FileName);
            }
        }
    }
}
