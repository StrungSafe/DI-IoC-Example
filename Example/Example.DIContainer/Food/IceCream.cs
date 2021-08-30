namespace Example.DIContainer.Food
{
    [Name("Ice Cream")]
    public class IceCream : IFood
    {
        private int percentOfIceCreamLeft;

        public IceCream()
        {
            percentOfIceCreamLeft = 100;
        }

        public void Eat()
        {
            if (percentOfIceCreamLeft == 0)
            {
                throw new NoFoodLeftException();
            }

            percentOfIceCreamLeft = 0;
        }

        public void Prepare()
        {
            // We don't need to prepare ice cream
        }
    }
}