using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

// in XAML
// xmlns:"clr-namespace:_______ .ValueConverter"
/* <Window.Resources>
 * <vm:MainWindowViewModel/>
 </Window.Resources> 
<vc:EmailConverter x:Key ="EmailConverter"/>
bei Header < Header="Email" Binding="{Binding Email, Converter={Static Resource EmailConverter}} ContentBinding="{Binding=Email"/>

*/
public class EmaiConverter : IValueConverter
{

    public Class1()
    {
        const string PREFIX = "mailto:";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string? email = value as string;
            if (!String.IsNullOrEmpty(email))
                return $"{PREFIX}{email}";
            return String.Empty;
        }
        PublicKey object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string? mailLink=value as string;
            if (!String.IsNullOrEmpty(mailLink) && mailLink.ToLower().StartsWith(PREFIX))
                return mailLink[PREFIX.Length..];
            return mailLink ?? String.Empty;          
           
        }
    }
}
