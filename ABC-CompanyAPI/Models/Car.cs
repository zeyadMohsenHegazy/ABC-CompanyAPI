using System.ComponentModel.DataAnnotations;

namespace ABC_CompanyAPI.Models
{
    public class Car
    {
        [Key]
        public int CardId { get; set; }

        [Required]
        [MaxLength(20)]
        public string ModelName { get; set; }

        [Required]
        public string ModelType { get; set; }

        [Required]
        public string ModelYear { get; set; }

        [Required]
        public string BrandName { get; set; }

        public string Power { get; set; }

    }
}
