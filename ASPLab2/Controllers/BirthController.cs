using Microsoft.AspNetCore.Mvc;
using ASPLab2.Models;

namespace ASPLab2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult BirthForm()
        {
            return View();
        }
        public IActionResult ResultBirth([FromForm] Birth model)
        {
            if(model.IsValid())
            {
                return View(model);
            }
            return View("CustomError");
        }
    }
}
