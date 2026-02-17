using Reservation.API.Infrastructure;
using Reservation.API.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Service
{
    public class ReservationService : IReservationService
    {
        public ReservationDto GetResBkgNumber(int bkgNumber)
        {
            return new ReservationDto()
            {
                Amaunt = 100,
                BkgDate = DateTime.Now,
                BkgNumber = bkgNumber,
                CheckinDate = DateTime.Now.AddDays(30),
                CheckoutDate = DateTime.Now.AddDays(37),
                Id = 1
            };
        }
    }
}
