using PunjabOrnaments.Service.APi.Data;
using PunjabOrnaments.Service.APi.Interface;
using Microsoft.EntityFrameworkCore;

namespace PunjabOrnaments.Service.APi.Extentions
{
    public static class ApplicationServiceExtentions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(opt => {
                opt.UseSqlite(config.GetConnectionString("DefaultConnectionSQLite"));
                //opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<ITokenService, Services.TokenService>();
            return services;
        }
    }
}
