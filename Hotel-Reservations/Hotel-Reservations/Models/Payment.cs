using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations.Models
{
    internal class Payment
    {
        public int Id { get; set; }

        public Reservation Reservations { get; set; }
        
    }
}
