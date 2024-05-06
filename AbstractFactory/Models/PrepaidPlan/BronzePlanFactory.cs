using AbstractFactory.Models.MinutesIncluded;
using AbstractFactory.Models.MobileData;
using AbstractFactory.Models.Price;
using AbstractFactory.Models.SocialNetwork;

namespace AbstractFactory.Models.PrepaidPlan
{
    public class BronzePlanFactory : IPrepaidPlanFactory
    {
        public string Name { get; set; } = "Bronze";
        public IMinutesIncludeFactory CreateMinutesInclude()
        {
            return new OneHundredMinutesInclude();
        }

        public IMobileDataFactory CreateMobileData()
        {
            return new ThirtyMobileData();
        }

        public IPriceFactory CreatePrice()
        {
            return new FifteenKPrice();
        }

        public ISocialNetworkFactory CreateSocialNetwork()
        {
            return new SimpleSocialNetwork();
        }
    }
}
