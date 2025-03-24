using Microsoft.Extensions.Configuration;

namespace SimpleConsoleApp
{
    internal class Configuration
    {
        public static Settings BuildAppSettings()
        {
            var environmentConfiguration = new ConfigurationBuilder()
                .AddEnvironmentVariables().Build();

            var environment = environmentConfiguration["RUNTIME_ENVIRONMENT"];
            Console.WriteLine(environment);

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json", false, false)
                //.AddJsonFile($"appSettings.{environment}.json", false, true)
                .Build();

            var settings = new Settings()
            {
                AppName = configuration["AppName"],
                ProviderName = configuration["ProviderName"],
                ConnectionStrings = new ConnectionStrings() { DbBox = configuration.GetConnectionString("DbBox")}
            };
            return settings;
        }
    }
}
