using AbstractFactory.Models.MinutesIncluded;
using AbstractFactory.Models.MobileData;
using AbstractFactory.Models.Price;
using AbstractFactory.Models.SocialNetwork;

namespace AbstractFactory.Models.PrepaidPlan
{
    public interface IPrepaidPlanFactory
    {
        string Name { get; set; }
        IMinutesIncludeFactory CreateMinutesInclude();
        IMobileDataFactory CreateMobileData();
        ISocialNetworkFactory CreateSocialNetwork();
        IPriceFactory CreatePrice();

    }
}
