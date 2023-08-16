using ABC_CompanyAPI.BLL;
using ABC_CompanyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ABC_CompanyAPI.DAL
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CarRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;   
        }
        public IEnumerable<Car> GetAllCars()
        {
            return _dbContext.Cars.ToList();
        }
    }
}
