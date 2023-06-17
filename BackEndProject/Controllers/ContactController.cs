using Microsoft.AspNetCore.Mvc;

namespace BackEndProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
