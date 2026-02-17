using Reservation.API.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Infrastructure
{
    public interface IReservationService
    {
        public ReservationDto GetResBkgNumber(int bkgNumber);
    }
}
