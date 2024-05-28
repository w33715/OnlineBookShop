using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DragAndDrop
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

        private void Rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(redRectangle, redRectangle, DragDropEffects.Move);
            }
        }

        private void canvas_Drop(object sender, DragEventArgs e)
        {

        }

        private void canvas_DragOver(object sender, DragEventArgs e)
        {
            Point dropPosition = e.GetPosition(canvas);
            Canvas.SetLeft(redRectangle, dropPosition.X);
            Canvas.SetTop(redRectangle, dropPosition.Y);
        }
    }
}
