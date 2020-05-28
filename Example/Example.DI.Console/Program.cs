namespace Example.DI.Console
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("I'm hungry, what do we have to eat? ");

                string input = Console.ReadLine();
                IFood food;

                // All of our classes are newed here
                var human = new Human();
                if (input == "orange")
                {
                    food = new Orange();
                }
                else if (input == "steak")
                {
                    food = new Steak();
                }
                else
                {
                    throw new Exception("I don't know how to eat " + input);
                }

                human.EatFood(food);

                Console.WriteLine("Thanks, that was good");
            }
        }
    }
}