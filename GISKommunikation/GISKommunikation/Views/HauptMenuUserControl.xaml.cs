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

namespace GISKommunikation.Views
{
    /// <summary>
    /// Interaktionslogik für hauptMenuUserControl.xaml
    /// </summary>
    public partial class HauptMenuUserControl : UserControl
    {
        public HauptMenuUserControl()
        {
            InitializeComponent();
        }
        private void btnMenuClose_Click(object sender, RoutedEventArgs e)
        {
          Visibility= Visibility.Hidden; 
        }

    }
}
