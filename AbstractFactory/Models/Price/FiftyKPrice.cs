namespace AbstractFactory.Models.Price
{
    public class FiftyKPrice : IPriceFactory
    {
        public string Name { get; set; } = "Fifty thousand Price";
        public string Value { get; set; } = "$50.000";
    }
}
