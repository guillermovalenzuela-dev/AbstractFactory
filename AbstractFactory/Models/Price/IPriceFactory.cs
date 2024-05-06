namespace AbstractFactory.Models.Price
{
    public interface IPriceFactory
    {
        string Name { get; set; }
        string Value { get; set; }
    }
}