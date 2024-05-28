using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace IValueConverter_INotifyPropertyChanged
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }


    }
    public class TextToBoolConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string)
                if (value.Equals("Yes"))
                    return true;
                else
                    return false;
            return false;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value == true)
                return "Yes";
            else return "No";
        }
    }
}
