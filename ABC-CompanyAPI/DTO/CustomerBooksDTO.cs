using System.ComponentModel.DataAnnotations;

namespace ABC_CompanyAPI.DTO
{
    public class CustomerBooksDTO
    {
        public string CustomerName { get; set; }
        public string Nationality { get; set; }
        public string DrivingLicenseNum { get; set; }
        public DateTime TransactionDate { get; set; }
        public string AdvancedPayment { get; set; }
    }
}
