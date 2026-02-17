using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;

namespace Reservation.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ResController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(reservationService.GetResBkgNumber(id));
        }
    }
}
