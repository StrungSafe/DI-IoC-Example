namespace Example.DIContainer
{
    using System;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    public class FeedHumans
    {
        private readonly IIOService ioService;

        private readonly ILogger<FeedHumans> logger;

        private readonly IServiceProvider provider;

        public FeedHumans(ILogger<FeedHumans> logger, IServiceProvider provider, IIOService ioService)
        {
            this.logger = logger;
            this.provider = provider;
            this.ioService = ioService;
        }

        public void Eat()
        {
            var human = provider.GetRequiredService<Human>();
            var foodFactory = provider.GetRequiredService<IFoodFactory>();

            var input = string.Empty;

            while (true)
            {
                try
                {
                    ioService.Write("What type of food? ");
                    input = ioService.Read();
                    logger.LogDebug("What type of food? {input}", input);
                    human.EatFood(foodFactory.NewFood(input));
                }
                catch (Exception ex)
                {
                    logger.LogError($"There was a problem eating {input}", ex);
                }
                
                ioService.Write("Continue eating? ");
                string eatMore = ioService.Read();
                if (eatMore?.Equals("n", StringComparison.InvariantCultureIgnoreCase) ?? false)
                {
                    break;
                }
            }
        }
    }
}