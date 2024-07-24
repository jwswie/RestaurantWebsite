using Microsoft.EntityFrameworkCore;
//using RestaurantWebsite.Models;

namespace RestaurantWebsite
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { /*Database.EnsureCreated();*/ }
    }
}