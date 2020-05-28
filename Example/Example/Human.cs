namespace Example
{
    using System;

    public class Human
    {
        public void EatFood()
        {
            // We've coupled ourselves to the Console implementation
            Console.WriteLine("I'm hungry, what do we have to eat? ");
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
            //
            // Adding more types of foods means we need to add more conditional blocks and we need to know how to eat the pie too
            // This class can get complex and large fast if we don't invert the control of creating the food
            // We will also need to abstract how to eat food so we can invert the control of how to eat food to each food type
            //
            // Now what if we need a stomach class to know all of these types of food too?
            // For every type of food, we would need to now touch two classes as well as more code branches which grows the complexity further
            // Coding to abstractions (interfaces) and inverting control will make these classes easier to manage and evolve
            //
            //else if (food == "apple pie")
            //{
            //    var pie = new ApplePie();
            //    pie.Warm();
            //    pie.Eat();
            //}
            else
            {
                throw new Exception("I don't know how to eat " + food);
            }

            Console.WriteLine("Thanks, that was good");
        }
    }
}