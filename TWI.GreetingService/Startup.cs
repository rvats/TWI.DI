using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TWI.GreetingService
{
    public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddScoped<IGreetingService, GreetingService>();
            if (DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 12)
            {
                services.AddSingleton<IGreetingService>(new FlexibleGreetingService("Good Morning"));
            }
            else if (DateTime.Now.Hour == 12)
            {
                services.AddSingleton<IGreetingService>(new FlexibleGreetingService("Good Noon"));
            }
            else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 16)
            {
                services.AddSingleton<IGreetingService>(new FlexibleGreetingService("Good After Noon"));
            }
            else if (DateTime.Now.Hour >= 16 && DateTime.Now.Hour < 21)
            {
                services.AddSingleton<IGreetingService>(new FlexibleGreetingService("Good Evening"));
            }
            else if (DateTime.Now.Hour >= 21)
            {
                services.AddScoped<IGreetingService>(factory => { return new FlexibleGreetingService("Good Night"); });
            }
            else
            {
                services.AddSingleton<IGreetingService>(new FlexibleGreetingService("Hello"));
            }
        }

        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env)
        {
            app.UseHelloWorld();
            app.UseHelloDevelopers();
        }
    }
}
