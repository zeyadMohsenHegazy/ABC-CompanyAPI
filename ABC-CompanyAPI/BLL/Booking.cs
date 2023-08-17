using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC_CompanyAPI.BLL
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public DateTime TransactionDate { get; set; } 
        public string AdvancedPayment { get; set; }

        [ForeignKey("customer")]
        public int CustomerId { get; set; }

        //we made it virtual to achieve lazy loading
        public virtual Customer customer { get; set; }
    }
}
