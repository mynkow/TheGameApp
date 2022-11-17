using EfHater;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GamePlatform.Api
{
    public static class GamePlatfromServices
    {
        public static IServiceCollection AddGamePlatform(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<GameAppService>();

            services.AddEntityFramework(configuration);

            return services;
        }

        private static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GameContext>(options =>
                 options.UseSqlServer(configuration.GetConnectionString("GameDatabase")));

            return services;
        }
    }
}
