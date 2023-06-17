using BackEndProject.DataAccessLayer;
using BackEndProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.ViewComponents
{
    public class SliderViewCompanent : ViewComponent
    {
        private readonly AppDbContext _context;

        public SliderViewCompanent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync();

            return await Task.FromResult(View(sliders));
        }
    }
}
