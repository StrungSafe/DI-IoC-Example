namespace Example
{
    using System;

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

    public class NoOrangeLeftException : Exception
    {
    }
}