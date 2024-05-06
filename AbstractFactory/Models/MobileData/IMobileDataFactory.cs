namespace AbstractFactory.Models.MobileData
{
    public interface IMobileDataFactory
    {
        string Name { get; set; }
        string Limit { get; set; }
    }
}