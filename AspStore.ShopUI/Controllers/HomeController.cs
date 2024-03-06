using AspStore.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspStore.ShopUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(productRepository.GetAll());
        }
    }
}
