using EfHater;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
            string assName = typeof(GameContext).Assembly.GetName().Name;

            var gg = configuration.GetConnectionString("GameDatabase");

            services.AddDbContext<GameContext>(options =>
                 options.UseSqlServer(gg, maafaka => maafaka.MigrationsAssembly(assName)));

            return services;
        }
    }
}
