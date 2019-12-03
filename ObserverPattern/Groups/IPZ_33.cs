using ObserverPattern.Departments;
using System;

namespace ObserverPattern.Groups
{
    class IPZ_33 : IGroup
    {
        public string Name { get; set; }

        public IPZ_33()
        {
            Name = "IPZ-33";
        }

        public void GetNews(IDepartment department)
        {
            Console.WriteLine($"Group {Name} get news from {department.Name}");
        }
    }
}
