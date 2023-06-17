using BackEndProject.DataAccessLayer;
using BackEndProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int pageIndex = 1)
        {
            IQueryable<Category> categories = _context.Categories
                .Include(b => b.Products.Where(p => p.IsDeleted == false))
                .Include(b => b.Children.Where(p => p.IsDeleted == false))
                .Where(b => b.IsDeleted == false)
                .OrderByDescending(b => b.Id);

            int totalPages = (int)Math.Ceiling((decimal)categories.Count() / 3);

            ViewBag.TotalPages = totalPages;
            ViewBag.PageIndex = pageIndex;

            return View(categories.Skip((pageIndex - 1) * 3).Take(3).ToList());
        }

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}
