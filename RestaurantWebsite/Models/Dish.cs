using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class Dish
    {
        [Key]
        public int DishID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}
