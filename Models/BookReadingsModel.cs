using System.ComponentModel.DataAnnotations;

namespace BookReadings.Models;

public class BookReadingsModel
{
    [Key]
    public int Id { get; init; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string MonthOfTheYear { get; set; }
    public int Year { get; set; }

    public BookReadingsModel(string title, string author, string monthOfTheYear, int year)
    {
        Title = title;
        Author = author;
        MonthOfTheYear = monthOfTheYear;
        Year = year;
    }
}
