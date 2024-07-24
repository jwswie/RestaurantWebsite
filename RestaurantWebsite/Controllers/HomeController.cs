using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using RestaurantWebsite.Models;

namespace RestaurantWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var dishes = _context.Dishes.Include(d => d.Category).ToList();
            return View(dishes);
        }
    }
}
