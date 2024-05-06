namespace AbstractFactory.Models.MinutesIncluded
{
    public class OneHundredMinutesInclude : IMinutesIncludeFactory
    {
        public string Name { get; set; } = "One Hundred Minutes Include";
        public string QuantityPerMonth { get; set; } = "100";
    }
}
