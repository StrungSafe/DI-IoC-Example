namespace Example.Console
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var human = new Human();
                human.EatFood();
                Console.WriteLine();
            }
        }
    }
}