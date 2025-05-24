namespace BookReadings.Models;

public record BookReadingsRequest(string title, string author, string monthOfTheYear, int year);

