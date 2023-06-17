using BackEndProject.Models;
using BackEndProject.ViewModels.BasketVMs;

namespace BackEndProject.Interfaces
{
    public interface ILayoutService
    {
        Task<List<Setting>> GetSetting();
        Task<IEnumerable<Category>> GetCategories();
        Task<List<BasketVM>> GetBasket();
    }
}
