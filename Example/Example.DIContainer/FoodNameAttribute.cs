namespace Example.DIContainer
{
    using System;

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class FoodNameAttribute : Attribute
    {
        public FoodNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}