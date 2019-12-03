using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorated
{
    class Sugar : Decorator
    {
        public Sugar(Drink _drink) : base(_drink)
        {
        }

        public override string Make()
        {
            return $"Sugar({base.Make()})";
        }
    }
}
