public interface IPersonModel
{
    string FirstName { get; set; }
    string LastName { get; set; }
    IAccounts AccountsProcessor { get; set; }
}