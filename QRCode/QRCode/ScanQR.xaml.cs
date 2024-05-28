using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace QRCode
{
    /// <summary>
    /// Interaktionslogik für ScanQR.xaml
    /// </summary>
    public partial class ScanQR : UserControl
    {
        QRCodeDecoder decoder = new QRCodeDecoder();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public ScanQR()
        {
            InitializeComponent();
        }

        private void btnScanQR_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == true)
            {
                imgQR.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                txtQR.Text = decoder.Decode(new QRCodeBitmapImage(new Bitmap(openFileDialog.FileName)));
            }
        }
    }
}
