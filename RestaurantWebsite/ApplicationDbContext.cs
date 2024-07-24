using Microsoft.EntityFrameworkCore;
using RestaurantWebsite.Models;
//using RestaurantWebsite.Models;

namespace RestaurantWebsite
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { /*Database.EnsureCreated();*/ }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

}