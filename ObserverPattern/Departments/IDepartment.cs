using ObserverPattern.Groups;

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
