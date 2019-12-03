using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FindTime ft = new FindTime();
            Console.WriteLine("Time, when you go 8km on foot");
            ft.SetWay(new OnFoot());
            ft.Find(8000);

            Console.WriteLine();

            Console.WriteLine("Time, when you go 8km by bus");
            ft.SetWay(new ByBus());
            ft.Find(8000);

            Console.WriteLine();

            Console.WriteLine("Time, when you go 8km by car");
            ft.SetWay(new ByCar());
            ft.Find(8000);

            Console.ReadLine();
        }
    }
}
