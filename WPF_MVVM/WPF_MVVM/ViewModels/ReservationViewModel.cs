using System;
using WPF_MVVM.Models;

namespace WPF_MVVM.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;
        public string RoomID => _reservation.RoomID?.ToString();
        public string Username => _reservation.Username.ToString();
        public DateTime StartDate => _reservation.StartDate.Date;
        public DateTime EndTime => _reservation.EndDate.Date;

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}

