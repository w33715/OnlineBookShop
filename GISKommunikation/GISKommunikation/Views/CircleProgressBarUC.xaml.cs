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
using GISKommunikation.Views;

namespace GISKommunikation.Views
{
    /// <summary>
    /// Interaktionslogik für CircleProgressBarUC.xaml
    /// </summary>
    public partial class CircleProgressBarUC : UserControl
    {
        public CircleProgressBarUC()
        {
            InitializeComponent();
        }
        private void Storyboard_Completed(object sender, EventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
               

            }
        }
    }
}
