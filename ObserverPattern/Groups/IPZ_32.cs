using ObserverPattern.Departments;
using System;

namespace ObserverPattern.Groups
{
    class IPZ_32 : IGroup
    {
        public string Name { get; set; }

        public IPZ_32()
        {
            Name = "IPZ-32";
        }

        public void GetNews(IDepartment department)
        {
            Console.WriteLine($"Group {Name} get news from {department.Name}");
        }
    }
}
