using Microsoft.AspNetCore.Mvc;
using WebLessons_16Shop.Date.Interfaces;

namespace WebLessons_16Shop.Controllers
{
    public class BookControllers : Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly IBookCategory _allBookCategories;

        public BookControllers(IAllBooks iAllBooks, IBookCategory ibookCat)
        {

            _allBooks = iAllBooks;
            _allBookCategories = ibookCat;
        }

        public ViewResult List()//фу-ця возращает список всех товаров 
        {
           var books = _allBooks.Books;
            
            return View(books);
        } 


    }
}