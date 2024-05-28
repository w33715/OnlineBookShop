using MessagingToolkit.QRCode.Codec;
using Microsoft.Win32;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows;
using System.Windows.Controls;

namespace QRCode
{
    /// <summary>
    /// Interaktionslogik für CreateQR.xaml
    /// </summary>
    public partial class CreateQR : UserControl
    {
        QRCodeEncoder encoder = new QRCodeEncoder();
        Bitmap bitmap;
        SaveFileDialog saveFile = new SaveFileDialog();
        public CreateQR()
        {
            InitializeComponent();
        }

        private void btnCreateQR_Click(object sender, RoutedEventArgs e)
        {
            encoder.QRCodeScale = 20;
            bitmap = encoder.Encode(txtQR.Text);
            imgQR.Source = ConvertImage.ToBitmapImage(bitmap);
        }

        private void btnSaveQr_Click(object sender, RoutedEventArgs e)
        {
            saveFile.Filter = "PNG|*.png";
            saveFile.FileName = txtQR.Text;
            if (saveFile.ShowDialog() == true)
            {
                if (bitmap != null)
                {
                    bitmap.Save(string.Concat(saveFile.FileName), ImageFormat.Png);
                }
            }
        }
    }
}
