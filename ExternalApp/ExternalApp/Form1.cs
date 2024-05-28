using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace ExternalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Process process = Process.Start(openFileDialog.FileName);
                process.WaitForInputIdle();
                while (process.MainWindowHandle == IntPtr.Zero)
                {
                    Thread.Sleep(100);
                    process.Refresh();
                }
                SetParent(process.MainWindowHandle, this.Handle);



            }
        }
    }
}
