using WebLessons_16Shop.Date.Interfaces;
using WebLessons_16Shop.Models;

namespace WebLessons_16Shop.Date.mocks
{                             //Реализация Интерфейса для работы с Категориями
    public class MockCategory : IBookCategory // Реализация класса 
    {
        public IEnumerable<Category> AllCategories // Функция для возрата категории 
        {
            get // Возращаем котегории 
            {
                return new List<Category>
                {
                    new Category
                        { categoryName = "Бизнес-литература", desc = "Топ бизнес-книг от лучших коучей и бизнесменов" },
                    new Category { categoryName = "Художественная литература ", desc = "Лучшие любовные романы" },
                    new Category
                        { categoryName = "Книги для изучения иностранного языка ", desc = "Французкий,Английский,Немецкий" }
                };
            }
        }
    }
} 



