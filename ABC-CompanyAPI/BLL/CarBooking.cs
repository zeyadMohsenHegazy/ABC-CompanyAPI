using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC_CompanyAPI.BLL
{
    public class CarBooking
    {
        [Key]
        public int CarBookingId { get; set; }

        [Required]
        public string RentDuration { get; set; }

        [ForeignKey("car")]
        public int CarId { get; set; }
        public virtual Car car { get; set; }


        [ForeignKey("booking")]
        public int BookingId { get; set; }
        public virtual Booking booking { get; set; }
    }
}
