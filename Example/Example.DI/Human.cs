namespace Example.DI
{
    using System;

    public class Human
    {
        public void EatFood(IFood food)
        {
            food.Prepare();
            food.Eat();
        }
    }

    public interface IFood
    {
        void Eat();

        void Prepare();
    }

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

    public class Steak : IFood
    {
        private bool isCooked;

        private readonly int percentOfSteakLeft;

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

    public class NoFoodLeftException : Exception
    {
    }
}