namespace AbstractFactory.Models.MinutesIncluded
{
    public class UnlimitedMinutesInclude : IMinutesIncludeFactory
    {
        public string Name { get; set; } = "Unlimited Minutes Include";
        public string QuantityPerMonth { get; set; } = "Unlimited";
    }
}
