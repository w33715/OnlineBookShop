using BaseWpfApp4.View;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BaseWpfApp4.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        public MainViewModel()
        {
            OpenWindow1Command = new DelegateCommand(OnOpenWindow1CommandExecute);
            // To use DelegateCommand one need to be use Prism. TBC ?
        }


        private void OnOpenWindow1CommandExecute()
        {
            int i = 5;

            var clntWindow = new ClientWindow();
            clntWindow.ShowDialog();
        }


        public ICommand OpenWindow1Command { get; }
    }
}

