using PunjabOrnamentsAPI.Data;
using PunjabOrnamentsAPI.Interface;
using Microsoft.EntityFrameworkCore;

namespace PunjabOrnamentsAPI.Extentions
{
    public static class ApplicationServiceExtentions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(opt => {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            services.AddCors();
            services.AddScoped<ITokenService, PunjabOrnamentsAPI.Services.TokenService>();
            return services;
        }
    }
}