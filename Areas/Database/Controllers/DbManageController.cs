using AspMVCEcomerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    [Area("Database")]
    public class DbManageController : Controller
    {
        private readonly MyEcommerceDB _dbContext;

        public DbManageController(MyEcommerceDB dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: DbManageController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DeleteDb()
        {
            return View();
        }

        [TempData]
        public string ThongBao { set; get;}

        [HttpPost]
        public async Task<IActionResult> DeleteDbAsync(){
            var success = await _dbContext.Database.EnsureDeletedAsync();
            ThongBao = success ? "Xoa Database Thanh Cong" : "Khong Xoa Duoc Database";
            return RedirectToAction(nameof(Index));
        }

         [HttpPost]
        public async Task<IActionResult> Migrate(){
            await _dbContext.Database.MigrateAsync();
            ThongBao = "Tao Database Thanh Cong";
            return RedirectToAction(nameof(Index));
        }
    }
}
