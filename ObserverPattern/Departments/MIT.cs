using ObserverPattern.Groups;
using System;
using System.Collections.Generic;

namespace ObserverPattern.Departments
{
    class MIT : IDepartment
    {
        public string Name { get; set; }

        private List<IGroup> groups = new List<IGroup>();

        public MIT()
        {
            Name = "MIT";
        }

        public void Subscribe(IGroup _group)
        {
            Console.WriteLine($"{_group.Name} subscribed {Name} just right now.\n");
            groups.Add(_group);
        }

        public void Unsubscribe(IGroup _group)
        {
            Console.WriteLine($"{_group.Name} unsubscribed from {Name} just right now.\n");
            groups.Remove(_group);
        }

        public void Notify()
        {
            Console.WriteLine($"News about session. From {Name}\n");

            foreach (var _group in groups)
            {
                _group.GetNews(this);
            }
        }
    }
}
