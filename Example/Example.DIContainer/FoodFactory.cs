namespace Example.DIContainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    public class FoodFactory : IFoodFactory
    {
        private readonly ILogger<FoodFactory> logger;

        private readonly IServiceProvider provider;

        public FoodFactory(ILogger<FoodFactory> logger, IServiceProvider provider)
        {
            this.logger = logger;
            this.provider = provider;
        }

        public IFood NewFood(string input)
        {
            IEnumerable<IFood> foodServices = provider.GetServices<IFood>();

            IFood food = foodServices.First(service =>
                service.GetType().Name.Equals(input, StringComparison.InvariantCultureIgnoreCase));

            logger.LogDebug("The type of food human is eating is {food}", food.GetType().Name);

            return food;
        }
    }
}