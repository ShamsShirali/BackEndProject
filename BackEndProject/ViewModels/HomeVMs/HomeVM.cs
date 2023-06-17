using BackEndProject.Models;

namespace BackEndProject.ViewModels.HomeVMs
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> NewArrivals { get; set; }
        public IEnumerable<Product> MostViewProducts { get; set; }
        public IEnumerable<Product> FeaturedProducts { get; set; }
    }
}
