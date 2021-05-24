namespace Example.DIContainer.Food
{
    public class Apple : IFood
    {
        private int percentOfAppleLeft;

        public Apple()
        {
            percentOfAppleLeft = 100;
        }

        public void Eat()
        {
            if (percentOfAppleLeft == 0)
            {
                throw new NoFoodLeftException();
            }

            percentOfAppleLeft = 0;
        }

        public void Prepare()
        {
            // We don't need to prepare apples
        }
    }
}