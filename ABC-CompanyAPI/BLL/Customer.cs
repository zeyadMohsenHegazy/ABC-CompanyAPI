using System.ComponentModel.DataAnnotations;

namespace ABC_CompanyAPI.BLL
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string DrivingLicenseNum { get; set; }
    }
}
