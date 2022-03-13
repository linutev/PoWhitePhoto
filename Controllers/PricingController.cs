using Microsoft.AspNetCore.Mvc;
using PoWhitePhoto.Models;

namespace PoWhitePhoto.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Enquiry(EnquiryFormModel enquiry)
        {
            ViewBag.SucessMessage = "Your enquiry sucessfully submitted. We will contact you shortly.";
            return View();
        }
    }
}
