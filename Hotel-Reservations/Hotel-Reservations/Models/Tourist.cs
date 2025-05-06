using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations.Models
{
    internal class Tourist
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Reservation Reservation { get; set; }
    }
}
