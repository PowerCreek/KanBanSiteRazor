namespace KanBanApi.Implementation
{
    public static class StartupExts
    {

        public static IServiceCollection ImplementApi(this IServiceCollection services)
        {
            return services;
        }

        public static IConfiguration SetConfiguration(this IConfiguration configuration)
        {
            return configuration;
        }

    }
}
