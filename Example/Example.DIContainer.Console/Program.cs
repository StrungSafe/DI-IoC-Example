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
                       .AddTransient<IFood, Steak>()
                       .AddTransient<IFood, IceCream>()
                       // oranges can only be eaten once because only a single instance will created by the container
                       .AddSingleton<IFood, Orange>();

                service.AddSingleton<IIOService, ConsoleIOProvider>()
                       .AddTransient<FeedHumans>();
            }).Build();

            host.Services.GetRequiredService<FeedHumans>().Eat();
        }
    }
}