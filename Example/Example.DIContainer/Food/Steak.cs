namespace Example.DIContainer.Food
{
    public class Steak : IFood
    {
        private bool isCooked;

        private int percentOfSteakLeft;

        public Steak()
        {
            isCooked = false;
            percentOfSteakLeft = 100;
        }

        public void Eat()
        {
            if (percentOfSteakLeft == 0)
            {
                throw new NoFoodLeftException();
            }

            if (!isCooked)
            {
                throw new FoodNotReadyException();
            }

            percentOfSteakLeft = 0;
        }

        public void Prepare()
        {
            if (!isCooked)
            {
                isCooked = true;
            }
        }
    }
}