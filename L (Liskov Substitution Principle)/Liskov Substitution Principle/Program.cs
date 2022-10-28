using Liskov_Substitution_Principle;

class Program
{
    static void Main(string[] args)
    {
        // Liskov’s Substitution Principle

        // This principle suggests that “parent classes should be easily
        // substituted with their child classes without blowing up the application”

        #region LSP violation
        //Manager accountingVP = new Manager();

        //accountingVP.FirstName = "Emma";
        //accountingVP.LastName = "Stone";
        //accountingVP.CalculatePerHourRate(4);

        //Employee emp = new Manager();<----- We can't change Employee emp to CEO. LSP VIOLATION HERE

        //emp.FirstName = "Tim";
        //emp.LastName = "Corey";
        //emp.AssignManager(accountingVP);<----- Error Exception here because of CEO subClass
        //emp.CalculatePerHourRate(2);

        //Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

        //Console.ReadLine();
        #endregion

        #region LSP valide
        IManager accountingVP = new Manager();//We create an interface for each p

        accountingVP.FirstName = "Emma";
        accountingVP.LastName = "Stone";
        accountingVP.CalculatePerHourRate(4);

        BaseEmployee emp = new CEO();//Change class Employee by BaseEmployee; Abstract class

        emp.FirstName = "Tim";
        emp.LastName = "Corey";
        //emp.AssignManager(accountingVP); //not exist anymore 
        emp.CalculatePerHourRate(2);

        Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

        Console.ReadLine();
        #endregion
    }
}