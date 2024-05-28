using System.Windows;
using System.Windows.Media;
using Window = System.Windows.Window;


namespace MyProject
{
    /// <summary>
    /// Interaktionslogik für Win2.xaml
    /// </summary>
    public partial class Win2 : Window
    {
        private object e;
        private object index;

        public Win2()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // Class1.Name = txtTest.Text;


            this.Close();
        }

        private void btn39_Unchecked(object sender, RoutedEventArgs e)
        {
            btn39.Background = Brushes.Red;
            btn39.Foreground = Brushes.White;
        }

        private void btn39_Checked(object sender, RoutedEventArgs e)
        {
            btn39.Background = Brushes.Yellow;
            btn39.Foreground = Brushes.Black;
        }

        private void btn38_Unchecked(object sender, RoutedEventArgs e)
        {
            btn38.Background = Brushes.Red;
            btn38.Foreground = Brushes.White;
        }

        private void btn38_Checked(object sender, RoutedEventArgs e)
        {
            btn38.Background = Brushes.Yellow;
            btn38.Foreground = Brushes.Black;
        }

        private void Winds2_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs ex)
        {
            if (ex.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            //ToggleButton toggleButton = new ToggleButton();
            //toggleButton.Click += Btn_Click;

            //MessageBox.Show("I'm", " Klicked");

            var source = e.OriginalSource as FrameworkElement;
            if (DialogResult != true)
            {
                if (source == null)

                    return;

                // MessageBox.Show("'" + source.Tag.ToString() + "'");
                Class1.Name = Class1.Name + source.Tag.ToString() + ",";


            }





        }

        private void btn39_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn06_Unchecked(object sender, RoutedEventArgs e)
        {
            btn06.Background = Brushes.Red;
            btn06.Foreground = Brushes.White;
        }

        private void btn06_Checked(object sender, RoutedEventArgs e)
        {
            btn06.Background = Brushes.Yellow;
            btn06.Foreground = Brushes.Black;
        }
    }
}
