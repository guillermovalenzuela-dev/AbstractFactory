namespace AbstractFactory.Models.MinutesIncluded
{
    public interface IMinutesIncludeFactory
    {
        string Name { get; set; }
        string QuantityPerMonth { get; set; }
    }
}