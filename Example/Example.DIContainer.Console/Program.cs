namespace Example.DIContainer.Console
{
    using Food;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args).ConfigureServices((context, service) =>
            {
                service.AddSingleton<Human>()
                       .AddTransient<IFoodFactory, FoodFactory>()
                       .AddTransient<IFood, Apple>()
                       .AddTransient<IFood, Orange>()
                       .AddTransient<IFood, Steak>();

                service.AddSingleton<IIOService, ConsoleIOProvider>()
                       .AddTransient<FeedHumans>();
            }).Build();

            host.Services.GetRequiredService<FeedHumans>().Eat();
        }
    }
}