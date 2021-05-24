namespace Example.DIContainer
{
    public interface IFoodFactory
    {
        IFood NewFood(string input);
    }
}