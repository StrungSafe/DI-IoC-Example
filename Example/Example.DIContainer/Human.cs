﻿namespace Example.DIContainer
{
    public class Human
    {
        public void EatFood(IFood food)
        {
            food.Prepare();
            food.Eat();
        }
    }
}