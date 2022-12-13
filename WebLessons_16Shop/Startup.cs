using WebLessons_16Shop.Date.Interfaces;
using WebLessons_16Shop.Date.mocks;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebLessons_16Shop
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllBooks,MockBook>(); // Объеденяет интерфейс ( Связываем интерфейсы между собой ) 
            services.AddTransient<IBookCategory, MockCategory>(); // ( Интерфейс,затем класс который реализует ) 
            services.AddMvc();
        }

     
        
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage(); //Функция для отоброжения ошибки 
            app.UseStatusCodePages(); //  Функция для отоброжения кода страничек 
            app.UseStaticFiles(); // Отоброжения статических файлов ( картинки и т.д)
            app.UseMvcWithDefaultRoute(); // (?Юрел?) по умолчанию


        }
    }
}
