using BaseWpfApp4.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BaseWpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel _mainViewModel;

        // public MainWindow()
        public MainWindow(MainViewModel mainVM)
        {
            InitializeComponent();
             _mainViewModel = mainVM;
             DataContext = _mainViewModel;

        }

    }
}