namespace AbstractFactory.Models.MobileData
{
    public class SixtyMobileData : IMobileDataFactory
    {
        public string Name { get; set; } = "Sixty Giga Bytes";
        public string Limit { get; set; } = "60GB";
    }
}
