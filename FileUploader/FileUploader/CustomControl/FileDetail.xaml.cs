using System.Windows;
using System.Windows.Controls;

namespace FileUploader.CustomControl
{
    /// <summary>
    /// Interaktionslogik für FileDetail.xaml
    /// </summary>
    public partial class FileDetail : UserControl
    {
        public FileDetail()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get { return (string)GetValue(FileNameProperty); }
            set { SetValue(FileNameProperty, value); }
        }

        //Using a DependencyProperty as the backing store for FileName. This enable animation, styling, binding, etc...
        public static readonly DependencyProperty FileNameProperty =
            DependencyProperty.Register("FileName", typeof(string), typeof(FileDetail));

        public string FileSize
        {
            get { return (string)GetValue(FileSizeProperty); }
            set { SetValue(FileSizeProperty, value); }
        }

        //Using a DependencyProperty as the backing store for FileName. This enable animation, styling, binding, etc...
        public static readonly DependencyProperty FileSizeProperty =
            DependencyProperty.Register("FileSize", typeof(string), typeof(FileDetail));
        public string UploadProgress
        {
            get { return (string)GetValue(UploadProgressProperty); }
            set { SetValue(UploadProgressProperty, value); }
        }

        //Using a DependencyProperty as the backing store for FileName. This enable animation, styling, binding, etc...
        public static readonly DependencyProperty UploadProgressProperty =
            DependencyProperty.Register("UploadProgress", typeof(string), typeof(FileDetail));
        public string UploadSpeed
        {
            get { return (string)GetValue(UploadSpeedProperty); }
            set { SetValue(UploadSpeedProperty, value); }
        }

        //Using a DependencyProperty as the backing store for FileName. This enable animation, styling, binding, etc...
        public static readonly DependencyProperty UploadSpeedProperty =
            DependencyProperty.Register("UploadSpeed", typeof(string), typeof(FileDetail));


    }
}
