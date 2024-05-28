using WPF_MVVM.Models;

namespace WPF_MVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        public ViewModelBase CurrentViewModel { get; }


        public MainViewModel(Hotel hotel)
        {
            CurrentViewModel = new MakeReservationViewModel();
        }

        public MainViewModel()
        {
        }
    }
}
