namespace Example.DIContainer.Console
{
    using System;

    using Example.DIContainer.Food;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder().ConfigureServices((context, service) =>
            {
                service.AddSingleton<Human>()
                       .AddTransient<IFoodFactory, FoodFactory>()
                       .AddTransient<IFood, Apple>()
                       .AddTransient<IFood, Orange>()
                       .AddTransient<IFood, Steak>();
            }).Build();

            var human = host.Services.GetRequiredService<Human>();
            var foodFactory = host.Services.GetRequiredService<IFoodFactory>();

            try
            {
                Console.Write("What type of food? ");
                string input = Console.ReadLine();
                human.EatFood(foodFactory.NewFood(input));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}