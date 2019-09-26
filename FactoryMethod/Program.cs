using System;
using FactoryMethod.Creator;
using FactoryMethod.Models;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = new ConsoleKeyInfo();
            while (!(key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.NumPad4))
            {
                Logistics logistics = null;

                key = ShowMenu();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        logistics = new RoadLogistic();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        logistics = new SeaLogistic();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        break;
                }

                if (logistics != null)
                {
                    Console.WriteLine();
                    var transport = logistics.CreateTransport();
                    Console.WriteLine(transport.Deliver());
                    Wait();
                }
            }
        }

        private static void Wait()
        {
            Console.WriteLine("Press ESC to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
            }
        }

        private static ConsoleKeyInfo ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Deliver by road");
            Console.WriteLine("2. Deliver by sea");
            Console.WriteLine("4. Exit");
            return Console.ReadKey();
        }
    }
}
