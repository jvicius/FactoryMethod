using FactoryMethod.Models;
using System;

namespace FactoryMethod.Creator
{
    public class RoadLogistic : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
