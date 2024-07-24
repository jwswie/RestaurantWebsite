using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class Table
    {
        [Key]
        public int TableID { get; set; }
        [Required]
        public int TableNumber { get; set; }
        [Required]
        public int Seats { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
