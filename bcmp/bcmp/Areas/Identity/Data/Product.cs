using System.ComponentModel.DataAnnotations;

namespace bcmp.Areas.Identity.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [Range(0,1_00_000)]
        public double Price { get; set; }   
        public string Category { get; set; }
        public string Description { get; set; }

        [Required]
        public int Quantity {  get; set; }

    }
}
