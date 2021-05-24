namespace Example.DIContainer.Food
{
    public class Steak : IFood
    {
        private readonly int percentOfSteakLeft;

        private bool isCooked;

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