namespace GamePlatform.Api
{
    public static class GamePlatfromServices
    {
        public static IServiceCollection AddGamePlatform(this IServiceCollection services)
        {
            services.AddSingleton<GameAppService>();

            return services;
        }
    }
}
