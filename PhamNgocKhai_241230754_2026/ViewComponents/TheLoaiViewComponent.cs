using Microsoft.AspNetCore.Mvc;
using PhamNgocKhai_241230754_2026.Models;

namespace PhamNgocKhai_241230754_2026.ViewComponents
{
    public class TheLoaiViewComponent : ViewComponent
    {
        private readonly QlnhaSachContext _db;

        public TheLoaiViewComponent(QlnhaSachContext db)
        {
            _db = db;
        }


        public IViewComponentResult Invoke()
        {

            var dsTheLoai = _db.TheLoais.ToList();
            return View(dsTheLoai);
        }
    }



    
}
