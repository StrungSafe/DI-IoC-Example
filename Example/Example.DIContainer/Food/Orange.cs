namespace Example.DIContainer.Food
{
    public class Orange : IFood
    {
        private bool isPeeled;

        private int percentOfOrangeLeft;

        public Orange()
        {
            isPeeled = false;
            percentOfOrangeLeft = 100;
        }

        public void Eat()
        {
            if (percentOfOrangeLeft == 0)
            {
                throw new NoFoodLeftException();
            }

            percentOfOrangeLeft = 0;
        }

        public void Prepare()
        {
            if (!isPeeled)
            {
                isPeeled = true;
            }
        }
    }
}