using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name of the cookies is required"), MaxLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description of the cookies is required"), MaxLength(50)]
        public string Description { get; set; }

        [Range(1, 20, ErrorMessage = "The price can olny be in the range of 1 to 20. Fair Value!!")]
        public double Price { get; set; }
        public int StockCount { get; set; }

    }
}
