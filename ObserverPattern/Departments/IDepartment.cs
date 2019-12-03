using ObserverPattern.Groups;
using System.Collections.Generic;

namespace ObserverPattern.Departments
{
    interface IDepartment
    {
        string Name { get; set; }

        void Subscribe(IGroup group);

        void Unsubscribe(IGroup group);

        void Notify();
    }
}
