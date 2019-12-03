using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorated
{
    class Milk : Decorator
    {
        public Milk(Drink _drink) : base(_drink)
        {
        }
        public override string Make()
        {
            return $"Milk({base.Make()})";
        }
    }
}
