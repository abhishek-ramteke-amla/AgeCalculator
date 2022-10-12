using Microsoft.AspNetCore.Mvc;

namespace AgeCalculator.Controllers
{
    public class AgeController : Controller
    {
        [HttpGet]
        public IActionResult CalculateAge()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateCurrentAge()
        {
            return RedirectToAction();
        }
    }
}
