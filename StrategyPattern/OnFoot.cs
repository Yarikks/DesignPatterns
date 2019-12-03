using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class OnFoot:IWay
    {
        public void ThisWay(int dist)
        {
            Console.WriteLine($"You have to go on foot near {(double)(dist / 100)} minutes.");
        }
    }
}
