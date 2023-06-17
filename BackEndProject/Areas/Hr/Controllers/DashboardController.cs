using Microsoft.AspNetCore.Mvc;

namespace BackEndProject.Areas.Hr.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
