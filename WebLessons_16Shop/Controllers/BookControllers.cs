using Microsoft.AspNetCore.Mvc;
using WebLessons_16Shop.Date.Interfaces;
using WebLessons_16Shop.ViewModels;

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
            ViewBag.Title = "Страница с Книгами"; 

           BooksListViewModel obj = new BooksListViewModel();
           
           obj.allBooks = _allBooks.Books;
           
           obj.bookCategory = "Книги";

            return View(obj);  
        } 


    }
}