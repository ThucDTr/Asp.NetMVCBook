using App.Data;
using AspMVCEcomerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    [Area("Database")]
    public class DbManageController : Controller
    {
        private readonly MyEcommerceDB _dbContext;
        private readonly UserManager<AppUser> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        [ActivatorUtilitiesConstructor]
        public DbManageController(MyEcommerceDB dbContext, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
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

        public async Task<IActionResult> SeedData(){
            var roleNames = typeof(RoleName).GetFields().ToList();
            foreach(var r in roleNames){
                var roleName = (string) r.GetRawConstantValue();
                var rFound = await _roleManager.FindByNameAsync(roleName);
                if(rFound == null){
                    await _roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            var userAdmin = await _userManager.FindByNameAsync("admin");
            if(userAdmin == null)
            {
                userAdmin = new AppUser(){
                    UserName = "admin",
                    Email = "admin@gmail.com",
                    EmailConfirmed = true
                };

                await _userManager.CreateAsync(userAdmin, "admin123");
                await _userManager.AddToRoleAsync(userAdmin, RoleName.Administrator);

            }
            ThongBao = "Vua Seed Database";
            return RedirectToAction("Index");
        }
    }
}
