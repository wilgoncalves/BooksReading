﻿using BookReadings.Data;
using BookReadings.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReadings.Routes;

public static class BookReadingsRoute
{
    public static void BookReadingsRoutes(this WebApplication app)
    {
        var route = app.MapGroup("book");

        route.MapPost("", async (BookReadingsRequest request, BookContext context) =>
        {
            var book = new BookReadingsModel(request.title, request.author, request.monthOfTheYear, request.year);

            await context.AddAsync(book);
            await context.SaveChangesAsync();

            return Results.Ok(book);
        });

        route.MapGet("", async (BookContext context) =>
        {
            var books = await context.Books.ToListAsync();
            return Results.Ok(books);
        });

        route.MapPut("{id:int}", async (int id, BookReadingsRequest request, BookContext context) =>
        {
            var book = await context.Books.FirstOrDefaultAsync(x => x.Id == id);

            if (book == null)
                return Results.NotFound();

            book.Title = request.title;
            book.Author = request.author;
            book.MonthOfTheYear = request.monthOfTheYear;
            book.Year = request.year;
            await context.SaveChangesAsync();

            return Results.Ok(book);
        });

        route.MapDelete("{id:int}", async (int id, BookContext context) =>
        {
            var book = await context.Books.FirstOrDefaultAsync(x => x.Id == id);

            if (book == null)
                return Results.NotFound();

            context.Remove(book);
            await context.SaveChangesAsync();

            return Results.Ok();
        });
    }
}
