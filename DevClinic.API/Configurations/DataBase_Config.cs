using DevClinic.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevClinic.API.Configurations
{
    public static class DataBase_Config
    {
        public static void AddDatabaseConfigutation(this IServiceCollection services, IConfiguration configuration)
        {
            var conectionString = configuration.GetConnectionString("Database");
            services.AddDbContext<DevClinic_Context>(options => options.UseSqlServer(conectionString));
        }
        public static void UseDatabaseConfiguration(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = serviceScope.ServiceProvider.GetService<DevClinic_Context>();
            context.Database.Migrate();
            context.Database.EnsureCreated();
        }
    }
}
