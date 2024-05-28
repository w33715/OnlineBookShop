using System.Windows;

namespace DocumentViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myDocumentViewer.Document = this.ConvertPptxDocToXPSDoc(this.FileName, this.newXPSDocumentName).GetFixedDocumentSequence();
        }
    }
}
