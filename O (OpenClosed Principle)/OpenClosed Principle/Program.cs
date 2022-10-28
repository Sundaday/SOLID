using OpenClosed_Principle.models;

class Program
{
    static void Main(string[] args)
    {
        //Open/Closed Principle - OCP
        //This principle suggests that “classes should be open for extension but closed for modification”.

        //if the class A is written by the developer AA,
        //and if the developer BB wants some modification on that
        //then developer BB should be easily do that by extending class A,
        //but not by modifying class A.

        //Here we implement IPersonModel (interface) instead of PersonModel (class) directly.
        //This allow us to modify what we want by adding new classes instead of modifying existing classes.

        #region OCP
        List<IPersonModel> applicants = new List<IPersonModel>
        { 
            new PersonModel { FirstName = "Tim", LastName = "Corey" },
            new ManagerModel { FirstName = "Sue", LastName = "Storm" },
            new ExecutiveModel { FirstName = "Nancy", LastName = "Roman" }
        };

        List<EmployeeModel> employees = new List<EmployeeModel>();

        foreach (var person in applicants)
        {
            employees.Add(person.AccountsProcessor.Create(person));
        }
        foreach (var emp in employees)
        {
            Console.WriteLine($"{ emp.FirstName } { emp.LastName }: {emp.EmailAddress } {emp.isManager} {emp.isExecutive}");
        }
        Console.ReadLine();
        #endregion
    }
}