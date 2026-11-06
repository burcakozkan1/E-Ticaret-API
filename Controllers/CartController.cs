
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.UI.Controllers
{
    public class CartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // İleride buraya Session veya Veritabanından sepet verilerini çeken kodu ekleyebilirsin.
            // Şimdilik dinamik bir kontrol mekanizması olması için View'a boş bir liste gönderiyoruz.
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
