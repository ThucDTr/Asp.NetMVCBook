using AspMVCEcomerce.Service;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Area("ProductManage")]
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        private readonly ILogger<ProductController> _logger;

        public ProductController(ProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        // GET: Product
        public ActionResult Index()
        {
            var product = _productService.OrderBy(p => p.Name).ToList();
            return View(product);
        }

    }
}
