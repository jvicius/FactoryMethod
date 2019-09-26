using FactoryMethod.Models;
using System;

namespace FactoryMethod.Creator
{
    public class SeaLogistic : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
