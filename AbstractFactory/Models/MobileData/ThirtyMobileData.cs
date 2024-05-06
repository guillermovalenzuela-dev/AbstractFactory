namespace AbstractFactory.Models.MobileData
{
    public class ThirtyMobileData : IMobileDataFactory
    {
        public string Name { get; set; } = "Thirty Giga Bytes";
        public string Limit { get; set; } = "30GB";
    }
}
