using BethanysPieShop.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Web.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        public PieController(IPieRepository pieRepository)
        {
           _pieRepository = pieRepository; 
        }

        public IActionResult List()
        {
            ViewBag.Category = "All pies";
            IEnumerable<Pie> allPies = _pieRepository.AllPies;
            return View(allPies);
        }
    }
}
