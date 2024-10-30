using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCEcomerce.Service;
using Microsoft.AspNetCore.Mvc;

namespace AspMVCEcomerce.Controllers
{
    public class FirstController : Controller
    {
        private readonly ProductService _productservice;
        public FirstController(ProductService productservice){
            _productservice = productservice;
        }
        public string Index() => "Xin Chao Thuc";

        public void Nothing(){
            Response.Headers.Add("Hi", "Chao Thuc Nha");
        }

        public IActionResult Readme(){
            var content = @"
            Xin Chao Cac Ban
            Cac ban dang hoc ve ASP.Net Core MVC
            
            
            XuanthuLab.Net
            ";

            return Content(content, "text/html");
        }

        public IActionResult Show(){
            return View();
        }

        [TempData]
        public string ThongBao { get; set; }
        public IActionResult ViewProduct(int? id){
            var product = _productservice.Where(p => p.Id == id).FirstOrDefault();
            if(product == null){
               ThongBao = "San Pham Ban Yeu Cau Khong Co";
               return Redirect(Url.Action("Index", "Home"));
            }

            this.ViewData["product"] = product;
            return View("ViewProduct2");
        }
    }


}