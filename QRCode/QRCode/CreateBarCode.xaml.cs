using MessagingToolkit.Barcode;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace QRCode
{
    /// <summary>
    /// Interaktionslogik für CreateBarCode.xaml
    /// </summary>
    public partial class CreateBarCode : UserControl
    {
        BarcodeEncoder barEncoder = new BarcodeEncoder();
        WriteableBitmap bitmap;
        SaveFileDialog saveFile = new SaveFileDialog();
        public CreateBarCode()
        {
            InitializeComponent();
        }

        private void btnSaveBarcode_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCreateBarcode_Click(object sender, RoutedEventArgs e)
        {

            bitmap = barEncoder.Encode(BarcodeFormat.Code128B, txtQR.Text);
            imgBC.Source = ConvertBCImage.ToBitmapImage(bitmap);
            // imgBC.Stretch = Stretch.Fill;
        }
    }
}
