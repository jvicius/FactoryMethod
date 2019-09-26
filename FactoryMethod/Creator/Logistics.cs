using FactoryMethod.Models;

namespace FactoryMethod.Creator
{
    public abstract class Logistics
    {
        public abstract ITransport CreateTransport();
    }
}