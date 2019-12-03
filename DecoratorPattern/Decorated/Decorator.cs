using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorated
{
    abstract class Decorator : Drink
    {
        protected Drink drink;

        public Decorator(Drink _drink)
        {
            drink = _drink;
        }

        public void SetComponent(Drink _drink)
        {
            drink = _drink;
        }

        public override string Make()
        {
            if (drink != null)
            {
                return drink.Make();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
