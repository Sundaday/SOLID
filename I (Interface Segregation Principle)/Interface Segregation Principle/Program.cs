using Interface_Segregation_Principle.Book;

class Program
{
    static void Main(string[] args)
    {
        //Interface Segregation Principle
        // This principle suggests that “many client specific interfaces
        // are better than one general interface”.
        // or Client should not be force to depend on interfaces they don't use

        #region ISP violation
        // Here we have only one interface that is
        // implemented in all classes, even those that do not need it. 
        #endregion

        #region ISP valide
        IBorrowableBook dvd = new Book();

        dvd.Author = "hello";

        Console.WriteLine(dvd.Author);
        #endregion
    }
}