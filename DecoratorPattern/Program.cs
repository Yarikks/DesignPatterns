using DecoratorPattern.ConcreteDrinks;
using DecoratorPattern.Decorated;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Coffee coffee = new Coffee();
            Console.WriteLine("Client: I get a simple drink:");
            client.ClientCode(coffee);
            Console.WriteLine();

            Milk milk = new Milk(coffee);
            Sugar sugar = new Sugar(milk);
            Console.WriteLine("Client: Now I've got a decorated drink:");
            client.ClientCode(sugar);

            Console.ReadLine();
        }
    }
}
