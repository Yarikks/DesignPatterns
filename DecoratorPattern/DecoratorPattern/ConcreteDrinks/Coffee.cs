using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDrinks
{
    class Coffee : Drink
    {
        public override string Make()
        {
            return "Coffee";
        }
    }
}
