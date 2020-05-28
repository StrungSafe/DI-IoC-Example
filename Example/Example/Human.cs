namespace Example
{
    using System;

    public class Human
    {
        public void EatFood()
        {
            // We've coupled ourselves to the Console implementation
            string food = Console.ReadLine();

            // We are newing classes here too!
            if (food == "orange")
            {
                var orange = new Orange();
                orange.Peel();
                orange.Eat();
            }
            else if (food == "steak")
            {
                var steak = new Steak();
                steak.Cook();
                steak.Eat();
            }
            else
            {
                throw new Exception("I don't know how to eat " + food);
            }
        }
    }
}