namespace Example
{
    using System;

    public class Human
    {
        public void EatFood()
        {
            var orange = new Orange();
            orange.Peel();
            orange.Eat();

            var steak = new Steak();
            steak.Cook();
            steak.Eat();
        }
    }

    public class Orange
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
                throw new NoOrangeLeftException();
            }

            percentOfOrangeLeft = 0;
        }

        public void Peel()
        {
            if (!isPeeled)
            {
                isPeeled = true;
            }
        }
    }

    public class Steak
    {
        private bool isCooked;

        private int percentOfSteakLeft;

        public Steak()
        {
            isCooked = false;
            percentOfSteakLeft = 100;
        }

        public void Cook()
        {
            if (!isCooked)
            {
                isCooked = true;
            }
        }

        public void Eat()
        {
            if (percentOfSteakLeft == 0)
            {
                throw new NoSteakLeftException();
            }

            percentOfSteakLeft = 0;
        }
    }

    public class NoOrangeLeftException : Exception
    {
    }

    public class NoSteakLeftException : Exception
    {
    }
}