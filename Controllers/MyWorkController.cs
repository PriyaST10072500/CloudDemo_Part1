using Microsoft.AspNetCore.Mvc;

namespace CloudDemo_Part_1.Controllers
{
    public class MyWorkController : Controller
    {
        public IActionResult MyWork()
        {
            return View();
        }
    }
}
