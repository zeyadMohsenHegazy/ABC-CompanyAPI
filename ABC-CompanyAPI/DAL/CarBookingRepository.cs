using ABC_CompanyAPI.BLL;

namespace ABC_CompanyAPI.DAL
{
    public class CarBookingRepository : ICarBookings
    {
        private readonly ApplicationDbContext _context;
        public CarBookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddCarBooking(CarBooking carBooking)
        {
            _context.CarBookings.Add(carBooking);
            _context.SaveChanges();
        }
    }
}
