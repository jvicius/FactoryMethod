namespace FactoryMethod.Models
{
    public class Truck : ITransport
    {
        public string Deliver()
        {
            return "Deliver from road";
        }
    }
}
