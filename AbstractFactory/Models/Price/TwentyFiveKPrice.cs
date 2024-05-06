namespace AbstractFactory.Models.Price
{
    public class TwentyFiveKPrice : IPriceFactory
    {
        public string Name { get; set; } = "Twenty five thousand Price";
        public string Value { get; set; } = "$25.000";
    }
}
