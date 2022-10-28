using S_Single_Responsability_Principle_;

class Program
{
    static void Main (string[] args)
    {
        #region THIS IS A BAD CODE
        ////Entry message
        //Console.WriteLine("Welcome to my application");

        ////Ask for user information
        //Person user = new Person();

        //Console.Write("What's your first name ?");
        //user.FirstName = Console.ReadLine();

        //Console.Write("What's your last name ?");
        //user.LastName = Console.ReadLine();

        ////Validator
        //if (string.IsNullOrWhiteSpace(user.FirstName))
        //{
        //    Console.WriteLine("You did not give us a valid first name!");
        //    Console.ReadLine();
        //    return;
        //}

        //if (string.IsNullOrWhiteSpace(user.LastName))
        //{
        //    Console.WriteLine("You did not give us a valid last name!");
        //    Console.ReadLine();
        //    return;
        //}

        ////Create a username for the person
        //Console.WriteLine($"Your username is {user.FirstName.Substring(0,1)}{user.LastName}");
        //Console.ReadLine();
        #endregion

        //S — Single Responsibility Principle (known as SRP)
        //The name itself suggest that the “class should be having one and only one responsibility”

        #region THIS IS A GOOD CODE SRP
        // New welcome method
        StandardMessages.WelcomeMessage();

        // Create new person user with readline data
        Person user = PersonDataCapture.Capture();

        // Validator methode for empty field
        bool isUserValide = PersonValidator.Validate(user);

        // More accurate & readable condition
        if (!isUserValide) 
        {
            StandardMessages.EndApplication();
            return;
        }

        // NameGenerator method 
        AccountGenerator.CreateAccount(user);

        // End Application method
        StandardMessages.EndApplication();
        #endregion
    }
}