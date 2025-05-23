using BookReadings.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReadings.Data;

public class BookContext : DbContext
{
    public DbSet<BookReadingsModel> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=booksreading.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}
