using Microsoft.EntityFrameworkCore;

namespace ABC_CompanyAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Car> Cars { get; set; }
    }
}
