using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ByCar: IWay
    {
        public void ThisWay(int dist)
        {
            Console.WriteLine($"You have to go by car near {(double)(dist / 1500)} minutes");
        }
    }
}
