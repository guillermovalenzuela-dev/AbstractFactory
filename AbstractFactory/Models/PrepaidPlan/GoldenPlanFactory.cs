using AbstractFactory.Models.MinutesIncluded;
using AbstractFactory.Models.MobileData;
using AbstractFactory.Models.Price;
using AbstractFactory.Models.SocialNetwork;

namespace AbstractFactory.Models.PrepaidPlan
{
    public class GoldenPlanFactory : IPrepaidPlanFactory
    {
        public string Name { get; set; } = "Golden";
        public IMinutesIncludeFactory CreateMinutesInclude()
        {
            return new UnlimitedMinutesInclude();
        }

        public IMobileDataFactory CreateMobileData()
        {
            return new OneHundredTwentyMobileData();
        }

        public IPriceFactory CreatePrice()
        {
            return new FiftyKPrice();
        }

        public ISocialNetworkFactory CreateSocialNetwork()
        {
            return new CompleteSocialNetwork();
        }
    }
}
