namespace AbstractFactory.Models.SocialNetwork
{
    public interface ISocialNetworkFactory
    {
        string Name { get; set; }
        string Networks { get; set; }
    }
}