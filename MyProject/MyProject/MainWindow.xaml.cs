using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;



namespace MyProject
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window


    {

        DispatcherTimer timer;
        bool IsPanelVisible;
        double panelWidth;
        private readonly IEnumerable<System.Windows.Controls.Control> Controls;
        public static string bloedeVariable;
        public string Name1 { get => name; set => name = value; }

        private string name;
        private int i;
        private string b;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 5);
            timer.Tick += Timer_Tick;
            panelWidth = menuPanel.Width;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (IsPanelVisible)
            {
                menuPanel.Width += 5;
                if (menuPanel.Width >= panelWidth)
                {
                    timer.Stop();
                    IsPanelVisible = false;

                }
            }
            else
            {
                menuPanel.Width -= 5;
                if (menuPanel.Width <= 70)
                {
                    timer.Stop();
                    IsPanelVisible = true;

                }
            }
        }


        public void ShowPanel()
        {
            IsPanelVisible = true;
        }
        public void HiddePanel()
        {
            IsPanelVisible = false;
        }
        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void btnMenuMin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnFilterOff_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow mainWindow = new MainWindow();    
            // foreach (System.Windows.Controls.Control c in CheckBox)
            // {
            //     if(c is System.Windows.Controls.CheckBox)
            //     {
            //         System.Windows.Controls.CheckBox cb = (CheckBox)c;
            //         if (cb.IsChecked == true)
            //             cb.IsChecked= false;
            //     }
            // }
        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txb.Text = "";
            Class1.Name = "";
            Win2 win2 = new Win2();
            win2.Owner = this;
            win2.ShowDialog();
            txb.Text = Class1.Name;
            i = 0;
            while (i < txb.Text.Length)
            {

                if (txb.Text.Substring(i, 1) != ",")
                {
                    b = txb.Text.Substring(i, 2);
                    //MessageBox.Show(b);
                    lbquery.Items.Add("Plz " + b);
                    i++;
                }
                else
                { b = ""; }
                i += 2;
            }



        }
    }
}
