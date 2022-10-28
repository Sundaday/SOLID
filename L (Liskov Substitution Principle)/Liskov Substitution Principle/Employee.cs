using Liskov_Substitution_Principle;
using Liskov_Substitution_Principle.Interfaces;

public class Employee : BaseEmployee, IManaged
{ 
    public IEmployee Manager { get; set; } = null;
    public virtual void AssignManager(IEmployee manager)
    {
        Manager = manager;
    }
}