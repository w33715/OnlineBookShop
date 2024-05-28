using System.Windows;
using System.Windows.Controls;

namespace TreeViewDemo
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TreeViewItem treeViewItem = new TreeViewItem();
            treeViewItem.Header = "Kategory";
            TreeViewItem treeViewItem1 = new TreeViewItem();
            treeViewItem1.Header = "Name";
            treeViewItem.Items.Add(treeViewItem1);
            TreeLeft.Items.Add(treeViewItem);

        }
    }
}
