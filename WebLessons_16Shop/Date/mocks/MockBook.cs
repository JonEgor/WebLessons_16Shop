using WebLessons_16Shop.Date.Interfaces;
using WebLessons_16Shop.Date.Models;

namespace WebLessons_16Shop.Date.mocks
{
    public class MockBook : IAllBooks
    {
        private readonly IBookCategory _categoryBooks = new MockCategory();
       
            
            public IEnumerable<Book> Books {
                
                
                get{
            
                return new List<Book>
                {
                    new Book
                    { 
                        name = "Думай и богатей", 
                        shortDesc = "Наполеон Хилл", 
                        longDesc = "Книга Хилла — это руководство по достижению богатства и успеха.", 
                        img = "https://chitatel.by/storage/thumbs/08/h501_w315_084c90d1834d325f86d8f438e2d4dda4.jpg", 
                        price = 20, 
                        IsFovourite = true,
                        available = true, 
                        Category = _categoryBooks.AllCategories.First()

                    },

                    new Book
                    {
                        name = "Полный курс французского языка",
                        shortDesc = "Валентина Горина",
                        longDesc = "Это учебное пособие отличает последовательность в изложении материала и его полнота.",
                        img = "https://oz.by/img/bg.v1669726775.png",
                        price = 50,
                        IsFovourite = false,
                        available = true,
                        Category = _categoryBooks.AllCategories.Last() // last ставиться для использования последней строки в MockCategory

                    },

                    new Book
                    {
                        name = "Английский язык. Новый самоучитель",
                        shortDesc = "Ирина Александровна Орлова",
                        longDesc = "Классический самоучитель А.В. Петровой, обновленный в соответствии с современными нормами языка, позволит быстро и самостоятельно выучить английский язык.",
                        img = "https://s5-goods.ozstatic.by/2000/788/501/10/10501788_0.jpg",
                        price = 20,
                        IsFovourite = true,
                        available = true,
                        Category = _categoryBooks.AllCategories.Last()

                    },


                    new Book
                    {
                        name = "Как завоёвывать друзей и оказывать влияние на людей",
                        shortDesc = "Дейл Карнеги",
                        longDesc = "Советы Дейла Карнеги позволят каждому читателю раскрыть свой потенциал и наконец-то громко заявить о себе.",
                        img = "https://oz.by/img/bg.v1669726775.png",
                        price = 20,
                        IsFovourite = false,
                        available = true,
                        Category = _categoryBooks.AllCategories.First()

                    },

                    new Book
                    {
                        name = "Head First. Изучаем C#",
                        shortDesc = "O'Really",
                        longDesc = "Сразу после приобретения минимума знаний, вы сможете написать первую программу. Затем, после расширения своих знаний, создадите карточную игру. ",
                        img = "https://www.kv.by/sites/default/files/pictures/userpictures/2021/01/07/2359/1.jpg",
                        price = 20,
                        IsFovourite = false,
                        available = false,
                        Category = _categoryBooks.AllCategories.Last()

                    },


                };
            }
        }
        
        
        
        
       
            
            
            public IEnumerable<Book> getFavBooks { get; set; }

        public Book GetBookById(int bookid)
        {
            throw new NotImplementedException();
        }
    }
}
