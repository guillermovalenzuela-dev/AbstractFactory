namespace AbstractFactory.Models.SocialNetwork
{
    public class CompleteSocialNetwork : ISocialNetworkFactory
    {
        public string Name { get; set; } = "Complete Social Networks";
        public string Networks { get; set; } = "Facebook, Whatsapp, Instagram, Waze";
    }
}
