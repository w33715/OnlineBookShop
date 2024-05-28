using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DragAndDrop
{
    /// <summary>
    /// Interaktionslogik für UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public static readonly DependencyProperty IsChildHitTestVisibleProperty =
            DependencyProperty.Register("IsChildHitTestVisible", typeof(bool),
                typeof(UserControl2), new PropertyMetadata(true));
        public bool IsChildHitTestVisible
        {
            get { return (bool)GetValue(IsChildHitTestVisibleProperty); }
            set { SetValue(IsChildHitTestVisibleProperty, value); }
        }
        public UserControl2()
        {
            InitializeComponent();
        }

        private void blueRectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildHitTestVisible = false;
                DragDrop.DoDragDrop(blueRectangle, new DataObject(DataFormats.Serializable, blueRectangle), DragDropEffects.Move);
                IsChildHitTestVisible = true;
            }
        }

        private void canvas_DragLeave(object sender, DragEventArgs e)
        {



            object data = e.Data.GetData(DataFormats.Serializable);
            if (data is UIElement element)
            {
                canvas.Children.Remove(element);
            }

        }
        private void canvas_Drop(object sender, DragEventArgs e)
        {

        }

        private void canvas_DragOver(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);
            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(canvas);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);
                if (!canvas.Children.Contains(element))
                {
                    canvas.Children.Add(element);
                }

            }
        }
    }
}
