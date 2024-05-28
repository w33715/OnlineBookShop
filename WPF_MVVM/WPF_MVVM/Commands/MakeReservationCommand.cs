using System.Windows;
using WPF_MVVM.Exceptions;
using WPF_MVVM.Models;
using WPF_MVVM.ViewModels;

namespace WPF_MVVM.Commands
{
    public class MakeReservationCommand : CommandsBase
    {
        private readonly Hotel _hotel;
        private readonly MakeReservationViewModel _makeReservationViewModel;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _hotel = hotel;
            _makeReservationViewModel = makeReservationViewModel;
        }
        public override void Execute(object parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username, _makeReservationViewModel.StartDate, _makeReservationViewModel.EndDate);

            try
            {
                _hotel.MakeReservation(reservation);
                MessageBox.Show("Successfully reserved room.", "Success", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            catch (ReservationConflictException)
            {

                MessageBox.Show("This room is already tacken.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
