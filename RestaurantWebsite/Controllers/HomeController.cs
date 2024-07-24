using Microsoft.AspNetCore.Mvc;
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

            return View();
        }
    }
}
