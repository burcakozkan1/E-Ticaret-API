
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.UI.Controllers
{
    public class CartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            
            var cartItems = new List<dynamic>(); 

            return View(cartItems);
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
