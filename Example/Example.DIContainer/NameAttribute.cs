namespace Example.DIContainer
{
    using System;

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class NameAttribute : Attribute
    {
        public NameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}