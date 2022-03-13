using Microsoft.AspNetCore.Mvc;

namespace PoWhitePhoto.Controllers
{
    public class WeddingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
