namespace Example.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                // We new a class here
                var human = new Human();
                human.EatFood();
            }
        }
    }
}