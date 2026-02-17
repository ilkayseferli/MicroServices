using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Model
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public int BkgNumber { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime BkgDate { get; set; }
        public double Amaunt { get; set; }
    }
}
