namespace FactoryMethod.Models
{
    public class Ship : ITransport
    {
        public string Deliver()
        {
            return "Deliver from sea";
        }
    }
}
