using ABC_CompanyAPI.BLL;
using ABC_CompanyAPI.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABC_CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        //to save the customer details from the Angular Html Form
        [HttpPost]
        public IActionResult AddCustomer([FromBody] Customer customer)
        {
            try
            {
                _customerRepository.AddCustomer(customer);
                return Ok("New Customer Added");
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while Adding new car.");
            }
        }
    }
}
