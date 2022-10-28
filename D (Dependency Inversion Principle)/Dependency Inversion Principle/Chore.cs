using Dependency_Inversion_Principle;

public class Chore : IChore
{
    private readonly ILogger _logger;
    private readonly IMessageSender _messageSender;

    public string? ChoreName { get; set; }
    public IPerson? Owner { get; set; }
    public double? HoursWorked { get; set; }
    public bool? IsComplete { get; set; }

    public Chore(ILogger logger, IMessageSender messageSender)
    {
        _logger = logger;
        _messageSender = messageSender;
    }

    public void PerformedWord(double hours)
    {
        HoursWorked += hours;
        _logger.Log($"Performed work on {ChoreName}");
    }
    public void CompleteChore()
    {
        IsComplete = true;
        _logger.Log($"Completed {ChoreName} was complete");

        _messageSender.SendMessage(Owner, $"The Chore {ChoreName} is complete");
    }
}