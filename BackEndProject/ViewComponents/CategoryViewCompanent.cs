using BackEndProject.DataAccessLayer;
using BackEndProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEndProject.ViewComponents
{
    public class CategoryViewCompanent : ViewComponent
    {
        private readonly AppDbContext _context;

        public CategoryViewCompanent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<Category> categories)
        {
            //IEnumerable<Category> categories = await _context.Categories.Where(c => c.IsDeleted == false && c.IsMain).ToListAsync();

            return View(categories);
        }
    }
}
