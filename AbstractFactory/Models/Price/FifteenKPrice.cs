namespace AbstractFactory.Models.Price
{
    public class FifteenKPrice : IPriceFactory
    {
        public string Name { get; set; } = "Fifteen thousand Price";
        public string Value { get; set; } = "$15.000";
    }
}
