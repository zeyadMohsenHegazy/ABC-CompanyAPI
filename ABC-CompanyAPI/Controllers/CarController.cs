using ABC_CompanyAPI.BLL;
using ABC_CompanyAPI.DAL;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ABC_CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
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


        [HttpGet("{id:int}")]
        public IActionResult GetCarById(int id)
        {
            if (ModelState.IsValid == true)
            {
                //var Car = dbContext.Cars.Find(id);
                return Ok();
            }
            else
            {
                return BadRequest("Car Not Exists !!!");
            }

        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            if (ModelState.IsValid)
            {
                //dbContext.Cars.Add(car);
                //dbContext.SaveChanges();
                return Ok("Added Successfully !");
            }
            else
            {
                return BadRequest("Not Added !!");
            }
        }
    }
}
