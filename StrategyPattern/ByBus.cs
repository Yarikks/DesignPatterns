using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ByBus:IWay
    {
        public void ThisWay(int dist)
        {
            Console.WriteLine($"You have to go by bus near {(double)(dist / 1083)} minutes");
        }
    }
}
