﻿public interface IChore
{
    string? ChoreName { get; set; }
    double? HoursWorked { get; set; }
    bool? IsComplete { get; set; }
    IPerson? Owner { get; set; }

    void CompleteChore();
    void PerformedWord(double hours);
}