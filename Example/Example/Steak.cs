namespace Example
{
    using System;

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

        public class NoSteakLeftException : Exception
        {
        }
    }
}