using System.Collections.Generic;
using System.Linq;
using WPF_MVVM.Exceptions;

namespace WPF_MVVM.Models
{
    public class ReservationsBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationsBook()
        {
            _reservations = new List<Reservation>();

        }
        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservations.Where(r => r.Username == username);
        }
        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in _reservations)

            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }

            }
            _reservations.Add(reservation);
        }
    }
}
