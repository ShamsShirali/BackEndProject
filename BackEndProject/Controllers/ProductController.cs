using BackEndProject.DataAccessLayer;
using BackEndProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Controllers
{
    public class ProductController : Controller
    {
        public readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Search(int? id, string search)
        {
            if (id != null && id > 0)
            {
                

                List<Product> products = await _context.Products.Where(c => c.IsDeleted == false && (
                c.Title.ToLower().Contains(search.ToLower()) ||
                (c.Brand != null ? c.Brand.Name.ToLower().Contains(search.ToLower()) : true) ||
                 (c.Category != null ? c.Category.Name.ToLower().Contains(search.ToLower()) : true) ||
                c.Description.ToLower().Contains(search.ToLower()))).ToListAsync();

                //return Json(products);
                return PartialView("_SearchPartial", products);
            }
            else
            {
                List<Product> products = await _context.Products.Where(c => c.IsDeleted == false && (
                c.Title.ToLower().Contains(search.ToLower()) ||
                (c.Brand != null ? c.Brand.Name.ToLower().Contains(search.ToLower()) : true) ||
                (c.Category != null ? c.Category.Name.ToLower().Contains(search.ToLower()) : true) ||
                c.Description.ToLower().Contains(search.ToLower()))).ToListAsync();

                //return Json(products);
                return PartialView("_SearchPartial", products);
            }
        }

        public async Task<IActionResult> Modal(int? id)
        {
            if (id == null) return BadRequest();

            Product product = await _context.Products.Include(p => p.ProductImages.Where(pi => pi.IsDeleted == false))
                .FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

            if (product == null) return NotFound();

            return PartialView("_ModalPartial", product);
        }
    }
}
