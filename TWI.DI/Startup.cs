using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TWI.DI
{
    public class Startup
    {
        public Startup()
        {
            var services = new ServiceCollection();
            var greetingService = new GreetingService();
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appSettings.json");
            var configuration = configurationBuilder.Build();

            services.AddScoped<IGreetingService, GreetingService>();
            services.AddSingleton<IConfiguration>(configuration);

            var provider = services.BuildServiceProvider();

            var myGreetings = provider.GetService<IGreetingService>();
            var myConfiguration = provider.GetService<IConfiguration>();

            myGreetings.WelcomeGreeting();
            greetingService.WelcomeGreeting();
        }
    }
}
