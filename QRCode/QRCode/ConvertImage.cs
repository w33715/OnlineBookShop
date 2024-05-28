using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;

namespace QRCode
{
    public static class ConvertImage
    {
        public static BitmapImage ToBitmapImage(this Bitmap bitmap)
        {
            using (var memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Png);
                memory.Position = 0;
                var bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();
                bitmapimage.Freeze();
                return bitmapimage;
            }
        }

    }
    // Converter for Barcode image
    public static class ConvertBCImage
    {
        public static WriteableBitmap ToBitmapImage(this WriteableBitmap wBitmap)
        {
            using (var memory1 = new MemoryStream())
            {
                //wBitmap.Clone();
                //memory1.Position = 0;
                //var bitmapimage1 = new BitmapImage();
                //bitmapimage1.BeginInit();
                //bitmapimage1.StreamSource = memory1;
                //bitmapimage1.CacheOption = BitmapCacheOption.OnLoad;
                //bitmapimage1.EndInit();
                //bitmapimage1.Freeze();
                return wBitmap;
            }
        }

    }
}
