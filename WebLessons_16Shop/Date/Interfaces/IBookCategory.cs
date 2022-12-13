using WebLessons_16Shop.Models;

namespace WebLessons_16Shop.Date.Interfaces
{
    public interface IBookCategory
    {
        IEnumerable<Category> AllCategories { get; }   // Возращает список 
    }
}
