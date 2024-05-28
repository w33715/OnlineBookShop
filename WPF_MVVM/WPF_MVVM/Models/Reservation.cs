using System;

namespace WPF_MVVM.Models
{
    public class Reservation
    {
        public Reservation(RoomID roomID, string Username, DateTime startDate, DateTime endDate)
        {
            RoomID = roomID;
            StartDate = startDate;
            EndDate = endDate;
        }

        public RoomID RoomID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Username { get; set; }
        public TimeSpan Length => EndDate.Subtract(StartDate);
        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID != RoomID)
            {
                return false;
            }
            return reservation.StartDate < EndDate || reservation.EndDate > StartDate;
        }
    }
}
