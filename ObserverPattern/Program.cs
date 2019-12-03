using System;
using ObserverPattern.Departments;
using ObserverPattern.Groups;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Workflow example for Departments and Groups.\n");

            SoftwareSystems softwareSys = new SoftwareSystems();
            MIT mit = new MIT();

            IPZ_33 group33 = new IPZ_33();
            IPZ_32 group32 = new IPZ_32();

            softwareSys.Subscribe(group33);
            softwareSys.Subscribe(group32);

            softwareSys.Notify();

            softwareSys.Unsubscribe(group32);

            mit.Subscribe(group33);

            mit.Notify();

            mit.Unsubscribe(group33);
            Console.ReadLine();
        }
    }
}
