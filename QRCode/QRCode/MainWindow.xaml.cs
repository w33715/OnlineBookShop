using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QRCode
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

        private void DragGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursor(index);
            switch (index)
            {
                case 0:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new CreateQR());
                    break;
                case 1:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new ScanQR());
                    break;
                case 2:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new CreateBarCode());
                    break;
            }
        }
        private void MoveCursor(int index)
        {
            TransitionContentSlide.OnApplyTemplate();
            TransitionGrid.Margin = new Thickness(0, ((index * 60) + 70), 0, 0);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            GridContent.Children.Clear();
            GridContent.Children.Add(new CreateQR());
        }
    }
}
