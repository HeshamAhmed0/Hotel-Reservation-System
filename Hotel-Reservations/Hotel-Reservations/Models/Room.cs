using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations.Models
{
    internal class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int RoomCode { get; set; }

        public Reservation Reservation { get; set; }
    }
}
