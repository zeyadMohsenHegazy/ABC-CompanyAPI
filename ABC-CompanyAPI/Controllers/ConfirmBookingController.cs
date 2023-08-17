using ABC_CompanyAPI.BLL;
using ABC_CompanyAPI.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABC_CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmBookingController : ControllerBase
    {
        private readonly ICarBookings _carBookings;
        public ConfirmBookingController( ICarBookings carBookings)
        {
            _carBookings = carBookings;
        }

        [HttpPost]
        public IActionResult ConfirmBooking(CarBooking carBooking)
        {
            _carBookings.AddCarBooking(carBooking);
            return Ok();
        }
    }
}
