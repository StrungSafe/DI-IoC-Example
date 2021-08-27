namespace Example.DIContainer.Console
{
    using System;

    public class ConsoleIOProvider : IIOService
    {
        public string Read()
        {
            return Console.ReadLine();
        }

        public void Write(string output)
        {
            Console.Write(output);
        }
    }
}