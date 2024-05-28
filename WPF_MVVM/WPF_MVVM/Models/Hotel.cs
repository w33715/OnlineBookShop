using System.Collections.Generic;

namespace WPF_MVVM.Models
{
    public class Hotel
    {
        private readonly ReservationsBook _reservationsBook;
        public string Name { get; set; }

        public Hotel(string name)
        {
            Name = name;
            _reservationsBook = new ReservationsBook();
        }
        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservationsBook.GetReservationsForUser(username);
        }
        public void MakeReservation(Reservation reservation)
        {
            _reservationsBook.AddReservation(reservation);
        }
    }
}
