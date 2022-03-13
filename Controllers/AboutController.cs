using Microsoft.AspNetCore.Mvc;

namespace PoWhitePhoto.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
