using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BusyIndicatorControl.UserControls
{
    /// <summary>
    /// Interaktionslogik für BusyIndicatorControl.xaml
    /// </summary>
    public partial class BusyIndicatorControl : UserControl
    {
        public BusyIndicatorControl()
        {
            InitializeComponent();
        }
        // Create ItemsSource dependency property of type URI for binding image
        public Uri ItemsSource
        {
            get
            { return (Uri)GetValue(ItemsSourceProperty  ); }
            set { SetValue(ItemsSourceProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ItemSource. This enables animation,
        // styling, binding, ect...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register( "ItemsSource",  typeof(BusyIndicatorControl),default);
        
        public string Text
        {
            get
            { return (string)GetValue(TextProperty); }
            set {SetValue(TextProperty,value); }
        }
        //Using a DependencyProperty as the backing store for Text.This enables animation,
        // styling, binding, ect...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register( "Text",  typeof(BusyIndicatorControl), default);
        public Visibility ProgressBarVisibility
        {
            get
            { return (Visibility)GetValue(ProgressBarVisibilityProperty); }
            set { SetValue(ProgressBarVisibilityProperty, value); }
        }
        //Using a DependencyProperty as the backing store for MyProperty.This enables animation,
        // styling, binding, ect...
        public static readonly DependencyProperty ProgressBarVisibilityProperty =
            DependencyProperty.Register("ProgressBarVisibility", typeof(BusyIndicatorControl), default);

        //Create ProgressBar IsIndeterminate dependency property of type bool
        public bool ProgressBarIsIndeterminate
        {
            get
            { return (bool)GetValue(ProgressBarIsIndeterminateProperty); }
            set { SetValue(ProgressBarIsIndeterminateProperty, value); }
        }
        //Using a DependencyProperty as the backing store for MyProperty.This enables animation,
        // styling, binding, ect...
        public static readonly DependencyProperty ProgressBarIsIndeterminateProperty =
            DependencyProperty.Register("ProgressBarIsIndeterminate", typeof(BusyIndicatorControl), default);

        public SolidColorBrush  ProgressForegroundBrush
        {
            get
            { return (SolidColorBrush)GetValue(ProgressForegroundBrushProperty); }
            set { SetValue(ProgressForegroundBrushProperty, value); }
        }
        //Using a DependencyProperty as the backing store for MyProperty.This enables animation,
        // styling, binding, ect...
        public static readonly DependencyProperty ProgressForegroundBrushProperty =
            DependencyProperty.Register("ProgressForegroundBrush", typeof(BusyIndicatorControl), default);


        public SolidColorBrush ProgressBackgroundBrush
        {
            get
            { return (SolidColorBrush)GetValue(ProgressBackgroundBrushProperty); }
            set { SetValue(ProgressBackgroundBrushProperty, value); }
        }
        //Using a DependencyProperty as the backing store for MyProperty.This enables animation,
        // styling, binding, ect...
        public static readonly DependencyProperty ProgressBackgroundBrushProperty =
            DependencyProperty.Register("ProgressBackgroundBrush", typeof(BusyIndicatorControl), default);
    }
}
