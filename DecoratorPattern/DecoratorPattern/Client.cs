using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Client
    {
        public void ClientCode(Drink _drink)
        {
            Console.WriteLine("RESULT: " + _drink.Make());
        }
    }
}
