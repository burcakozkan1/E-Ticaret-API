
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}