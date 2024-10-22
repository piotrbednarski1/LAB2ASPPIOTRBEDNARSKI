using ASPLab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPLab2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public enum Operators
        {
            Unknown, Add, Mul, Sub, Div
        }
        [HttpPost]
        public IActionResult Result([FromForm] Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
        public IActionResult Form()
        {
            return View();
        }
    }
}
