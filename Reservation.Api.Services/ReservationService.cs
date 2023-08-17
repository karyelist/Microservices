using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.Api.Infrastucture;
using Reservation.Api.Models;

namespace Reservation.Api.Services
{
    public class ReservationService : IReservation
    {
        

        public ReservationDto GetResByNumber(int Id)
        {
            return new ReservationDto()
            { Id = (new Random().Next(100)),
            Amount=15.00,
            BookingDate=DateTime.Now,
            CheckinDate=DateTime.Now.AddDays(30),
            CheckoutDate=DateTime.Now.AddDays(37),
            BookingNumber=Id
            };
         }
    }
}
