public class PersonModel : IPersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IAccounts AccountsProcessor { get; set; } = new Accounts();
}