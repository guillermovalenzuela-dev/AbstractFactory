namespace AbstractFactory.Models.SocialNetwork
{
    public class MediumSocialNetwork : ISocialNetworkFactory
    {
        public string Name { get; set; } = "Medium Social Networks";
        public string Networks { get; set; } = "Facebook, Whatsapp, Instagram";
    }
}
