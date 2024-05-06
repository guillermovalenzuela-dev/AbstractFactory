using AbstractFactory.Models.MinutesIncluded;
using AbstractFactory.Models.MobileData;
using AbstractFactory.Models.Price;
using AbstractFactory.Models.SocialNetwork;

namespace AbstractFactory.Models.PrepaidPlan
{
    public class SilverPlanFactory : IPrepaidPlanFactory
    {
        public string Name { get; set; } = "Silver";
        public IMinutesIncludeFactory CreateMinutesInclude()
        {
            return new OneThousandMinutesInclude();
        }

        public IMobileDataFactory CreateMobileData()
        {
            return new SixtyMobileData();
        }

        public IPriceFactory CreatePrice()
        {
            return new TwentyFiveKPrice();
        }

        public ISocialNetworkFactory CreateSocialNetwork()
        {
            return new MediumSocialNetwork();
        }
    }
}
