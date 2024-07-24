using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public int UserID { get; set; }
        public int TableID { get; set; }
        [Required]
        public DateTime ReservationDate { get; set; }
        [Required]
        public TimeSpan ReservationTime { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }
        [ForeignKey("TableID")]
        public Table Table { get; set; }
    }
}
