namespace Example.DI.Console
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                // We have decoupled the human class from Console
                // Now a human can work with vary input types much easier
                Console.WriteLine("I'm hungry, what do we have to eat? ");
                string input = Console.ReadLine();

                IFood food;

                // All of our classes are newed here
                var human = new Human();

                // We can further abstract this logic (and getting the input too) further to allow for flexibility
                // DI containers will help to select the proper class
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

                // The human class is no longer controlling the food it should eat, it is being handed food that it then eats
                human.EatFood(food);

                Console.WriteLine("Thanks, that was good");
            }
        }
    }
}