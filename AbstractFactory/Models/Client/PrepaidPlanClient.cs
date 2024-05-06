using AbstractFactory.Models.PrepaidPlan;
using System.Numerics;
using System.Reflection.Emit;

namespace AbstractFactory.Models.Client
{
    public class PrepaidPlanClient
    {
        private IPrepaidPlanFactory _prepaidPlanFactory;
        private const string _nameSpacePrefix = "AbstractFactory.Models.PrepaidPlan.";
        private const string _nameSpaceSufix = "PlanFactory";

        public PrepaidPlanClient(PrepaidPlanPackage prepaidPlan)
        {
            _prepaidPlanFactory = prepaidPlan switch
            {
                PrepaidPlanPackage.Bronze => new BronzePlanFactory(),
                PrepaidPlanPackage.Silver => new SilverPlanFactory(),
                PrepaidPlanPackage.Golden => new GoldenPlanFactory(),
                _ => throw new NotImplementedException()
            };
        }
        public PrepaidPlanClient(string prepaidPlan)
        {
            string typeName = $"{_nameSpacePrefix}{prepaidPlan}{_nameSpaceSufix}";
            _prepaidPlanFactory = Activator.CreateInstance(Type.GetType(typeName)) as IPrepaidPlanFactory;
        }

        public string Resume()
        {
            return @$"Prepaid Plan {_prepaidPlanFactory.Name}: 
Minutes Included: {_prepaidPlanFactory.CreateMinutesInclude().Name}
Mobile Data: {_prepaidPlanFactory.CreateMobileData().Name}
Social Network: {_prepaidPlanFactory.CreateSocialNetwork().Name}
Price: {_prepaidPlanFactory.CreatePrice().Name}";
        }
    }
}
