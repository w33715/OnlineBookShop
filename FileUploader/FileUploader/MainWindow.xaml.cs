﻿using FileUploader.CustomControl;
using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace FileUploader
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            { Multiselect = true };
            bool? response = ofd.ShowDialog();
            if (response == true)
            {
                //Get Selected Files
                string[] files = ofd.FileNames;

                // iterate and add all selected files to Upload
                for (int i = 0; i < files.Length; i++)
                {
                    string filename = System.IO.Path.GetFileName(files[i]);
                    FileInfo fileInfo = new FileInfo(files[i]);
                    UploadingFileList.Items.Add(new FileDetail()
                    {
                        FileName = filename,
                        // To Convert bytes to Mb=>bytes /1,049e+6
                        FileSize = string.Format("{0} {1}", (fileInfo.Length / 1.049e+6).ToString("0.0"), "Mb"),
                        UploadProgress = 100.ToString(),

                    });
                }
            }

        }

        private void Rectangle_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string fileName = System.IO.Path.GetFileName(files[0]);
                for (int i = 0; i < files.Length; i++)
                {
                    string filename = System.IO.Path.GetFileName(files[i]);
                    FileInfo fileInfo = new FileInfo(files[i]);
                    UploadingFileList.Items.Add(new FileDetail()
                    {
                        FileName = filename,
                        // To Convert bytes to Mb=>bytes /1,049e+6
                        FileSize = string.Format("{0} {1}", (fileInfo.Length / 1.049e+6).ToString("0.0"), "Mb"),
                        UploadProgress = 100.ToString(),

                    });
                }
            }
        }
    }
}
