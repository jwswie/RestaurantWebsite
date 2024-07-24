using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(255)]
        public string Username { get; set; }
        [StringLength(255)]
        public string HashedPassword { get; set; }
        [StringLength(255)]
        public string Salt { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
    }
}
