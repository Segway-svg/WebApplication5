using Microsoft.EntityFrameworkCore;
using OrderDataProvider;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApplication5
{
    public class Startup
    {
        // Встроенный интерфейс, содержащий по умолчанию настройки
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            using (OrderDbContext context = new OrderDbContext()) 
            { 
                context.Database.Migrate();
            }
        }


        // Метод для добавления всякого (формируем список используемых служб)
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Задаём детали для endpoint-ов (можно настроить с помощью атрибутов в контролере)
                endpoints.MapControllers();
            });
        }
    }
}
