using Microsoft.AspNetCore.Mvc;

namespace ABC_CompanyAPI.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
