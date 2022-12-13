using NuGet.Configuration;
using WebLessons_16Shop.Models;

namespace WebLessons_16Shop.Date.Models
{
    public class Book // Основа ( Шаблон )
    {
        public int id { get; set; }

        public string name { get; set; }

        public string shortDesc { get; set; } // Описание 

        public string longDesc { get; set; } // Подробное описание 

        public string img { get; set; } // URL Адрес на кратринку 

        public ushort price { get; set; }

        public bool IsFovourite { set; get; } // Рекомендации 

        public bool available { set; get; } // Наличие товара 

        public int categoryID { get; set; }

        public virtual Category Category { get; set; }
          

    }

}


