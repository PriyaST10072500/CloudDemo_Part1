using Microsoft.AspNetCore.Mvc;

namespace CloudDemo_Part_1.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
