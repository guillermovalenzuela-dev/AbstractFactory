namespace AbstractFactory.Models.SocialNetwork
{
    public class SimpleSocialNetwork : ISocialNetworkFactory
    {
        public string Name { get; set; } = "Simple Social Networks";
        public string Networks { get; set; } = "Facebook, Whatsapp";
    }
}
