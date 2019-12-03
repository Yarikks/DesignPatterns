using ObserverPattern.Departments;

namespace ObserverPattern.Groups
{
    interface IGroup
    {
        string Name { get; set; }
        void GetNews(IDepartment department);
    }
}
