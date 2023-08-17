using ABC_CompanyAPI.BLL;
using ABC_CompanyAPI.DAL;
using ABC_CompanyAPI.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABC_CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerBookingController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IBookingRepository _bookingRepository;
        public CustomerBookingController(ICustomerRepository customerRepository
                                        , IBookingRepository bookingRepository)
        {
            _customerRepository = customerRepository;
            _bookingRepository = bookingRepository;
        }

        //to save the customer details from the Angular Html Form
        [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerBooksDTO customer)
        {
            Customer customerInfo = new Customer();
            customerInfo.CustomerName = customer.CustomerName;
            customerInfo.DrivingLicenseNum = customer.DrivingLicenseNum;
            customerInfo.Nationality = customer.Nationality;

            Booking bookingInfo = new Booking();
            bookingInfo.AdvancedPayment = customer.AdvancedPayment;
            bookingInfo.TransactionDate = customer.TransactionDate;
            
            try
            {
                _customerRepository.AddCustomer(customerInfo);
                var Addedcustomer = _customerRepository.GetCustomer(customer.CustomerName);
                bookingInfo.CustomerId = Addedcustomer.CustomerId;
                _bookingRepository.AddBooking(bookingInfo);
                return Ok(new
                {
                    bookingId = bookingInfo.BookingId,
                    TransactionDate = bookingInfo.TransactionDate.ToString()
                });
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while Adding customer");
            }
        }
    }
}
