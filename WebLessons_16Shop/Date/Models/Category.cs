using WebLessons_16Shop.Date.Models;


namespace WebLessons_16Shop.Models
{
    public class Category
    {
        public int id { get; set; } // айди 

        public string categoryName { get; set; } // Название 

        public string desc { get; set; }

        public List<Book> books { get; set; }


    }
}
