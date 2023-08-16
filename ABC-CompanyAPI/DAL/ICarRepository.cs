using ABC_CompanyAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ABC_CompanyAPI.DAL
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
    }
}
