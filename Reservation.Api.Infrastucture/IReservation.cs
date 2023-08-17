using Reservation.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Api.Infrastucture
{
    public interface IReservation
    {

        public ReservationDto GetResByNumber(int Id);
    }
}
