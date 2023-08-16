using ABC_CompanyAPI.BLL;
using ABC_CompanyAPI.DAL;
using Microsoft.AspNetCore.Mvc;

namespace ABC_CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        #region Action to Get All Cars
        [HttpGet]
        public IActionResult GetAllCars()
        {
            try
            {
                var cars = _carRepository.GetAllCars();
                return Ok(cars);
            }
            catch (Exception ex)
            {
                return  BadRequest("An error occurred while retrieving all cars.");
            }
        }
        #endregion

        [HttpGet("{carId}")]
        public IActionResult GetCarById(int carId)
        {
            try
            {
                var car = _carRepository.GetCarById(carId);
                if (car == null)
                {
                    return NotFound($"Car with Id {carId} not found.");
                }
                return Ok(car);
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while retrieving the car.");
            }
        }

        [HttpPost]
        public IActionResult AddCar([FromBody] Car car)
        {
            try
            {
                _carRepository.AddCar(car);
                return Ok("New Car Added");
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while Adding new car.");
            }
        }





    }
}
