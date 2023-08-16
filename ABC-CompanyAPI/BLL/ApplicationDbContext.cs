using Microsoft.EntityFrameworkCore;

namespace ABC_CompanyAPI.BLL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarBooking> CarBookings { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
