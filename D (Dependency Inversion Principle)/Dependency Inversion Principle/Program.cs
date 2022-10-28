using Dependency_Inversion_Principle.Factory;

class Program
{
    static void Main(string[] args)
    {
        //Dependency Inversion Principe - DIP
        //"classes should depend on abstraction but not on concretion”.
        //if class A changes, the class B doesn’t need to care or know about the changes.

        //Here we created Factory class to avoid all creations of new instances
        //Factory is now the only spot for new something
        //Now i can very easly change Emailer by Texter in Factory without breaking my program, Great !

        #region DIP violation
        //Person owner = new Person
        //{
        //    FirstName = "Tim",
        //    LastName = "Corey",
        //    EmailAddress = "tim@gmail.com",
        //    PhoneNumber = "555-1234"
        //};

        //Chore chore = new Chore
        //{
        //    ChoreName = "Take out the thrash",
        //    Owner = owner
        //};

        //chore.PerformedWord(3);
        //chore.PerformedWord(1.5);
        //chore.CompleteChore();

        //Console.ReadLine();
        #endregion

        #region DIP valide
        IPerson owner = Factory.CreatePerson();
        owner.FirstName = "Tim";
        owner.LastName = "Corey";
        owner.EmailAddress = "tim@gmail.com";
        owner.PhoneNumber = "555-1234";

        IChore chore = Factory.CreateChore();
        chore.ChoreName = "Take out the thrash";
        chore.Owner = owner;

        chore.PerformedWord(3);
        chore.PerformedWord(1.5);
        chore.CompleteChore();

        Console.ReadLine();
        #endregion
    }
}