using WebLessons_16Shop.Date.Models;

namespace WebLessons_16Shop.Date.Interfaces
{
    public interface IAllBooks // Возращение товара по ID
    {
        IEnumerable<Book> Books {get; } // Получение и установка  данных
        IEnumerable<Book> getFavBooks { set; get; }
        Book GetBookById(int bookid);
    }
}
