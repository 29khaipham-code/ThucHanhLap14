using Microsoft.AspNetCore.Mvc;
using PhamNgocKhai_241230754_2026.Models;
using System.Diagnostics;

namespace PhamNgocKhai_241230754_2026.Controllers
{
    public class HomeController : Controller
    {

        private readonly QlnhaSachContext _db;
        public HomeController(QlnhaSachContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var dsSach = _db.Saches.Where(s => s.Gia >= 100).ToList();
            return View(dsSach);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult LocTheLoai(int Matl)
        {
            var dsTheLoai = _db.Saches.Where(s => s.MaTl == Matl).ToList();

            var TheLoai = _db.TheLoais.FirstOrDefault(t => t.MaTl == Matl);
            ViewBag.tieude = TheLoai != null ? TheLoai.TenTl : "PhamNgocKhai";
            return PartialView("PhamNgocKhai_MainContent",dsTheLoai);
        }
    }
}
