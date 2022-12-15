using WebLessons_16Shop.Date.Models;

namespace WebLessons_16Shop.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> allBooks { get; set; }
        
        public string bookCategory { get; set; }
    }
}
