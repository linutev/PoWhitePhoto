using Microsoft.AspNetCore.Mvc;

namespace PoWhitePhoto.Controllers
{
    public class FamilyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
