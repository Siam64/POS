using Microsoft.AspNetCore.Mvc;
using PointOfSale.Data;

namespace PointOfSale.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly PointOfSaleContext _context;
        
        public AdminController(PointOfSaleContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
