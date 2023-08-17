using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.Api.Infrastucture;
using Reservation.Api.Models;
using Reservation.Api.Services;

namespace ReservationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservation reservationService;

        public ResController(IReservation _reservationService)
        {
            reservationService = _reservationService;
        }

        [HttpGet("{Id}")]

        public ReservationDto GetReserverationById(int Id)
        {
            return reservationService.GetResByNumber(Id);
        }




    }
}
