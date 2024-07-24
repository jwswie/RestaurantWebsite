using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int ReservationID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [ForeignKey("ReservationID")]
        public Reservation Reservation { get; set; }
    }
}
