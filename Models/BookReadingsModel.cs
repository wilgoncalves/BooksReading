namespace BookReadings.Models;

public class BookReadingsModel
{
    public Guid Id { get; init; }
    public string Title { get; set; }
    public string MonthOfTheYear { get; set; }
    public int Year { get; set; }

    public BookReadingsModel(string title, string monthOfTheYear, int year)
    {
        Id = new Guid();
        Title = title;
        MonthOfTheYear = monthOfTheYear;
        Year = year;
    }
}
