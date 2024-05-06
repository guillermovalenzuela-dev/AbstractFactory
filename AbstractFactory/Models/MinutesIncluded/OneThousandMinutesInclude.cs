namespace AbstractFactory.Models.MinutesIncluded
{
    public class OneThousandMinutesInclude : IMinutesIncludeFactory
    {
        public string Name { get; set; } = "One Thousand Minutes Include";
        public string QuantityPerMonth { get; set; } = "1000";
    }
}
