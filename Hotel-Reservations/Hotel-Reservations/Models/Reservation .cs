using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations.Models
{
    internal class Reservation
    {
        public int ReservationId { get; set; }


        public ICollection<Tourist> Tourist { get; set; }
        public int TouristId { get; set; }

        public string TouristName { get; set; }



        public Room Room { get; set; }
        public int RoomCode { get; set; }

        public int PaidStatement { get; set; }



    }
}
