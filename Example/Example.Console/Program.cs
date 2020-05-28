namespace Example.Console
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("I'm hungry, what do we have to eat? ");

                // We new a class here
                var human = new Human();

                human.EatFood();

                Console.WriteLine("Thanks, that was good");
            }
        }
    }
}