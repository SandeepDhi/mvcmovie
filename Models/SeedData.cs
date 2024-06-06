using Microsoft.EntityFrameworkCore;
using mvcmovie.Data;
using mvcmovie.Migrations;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new mvcmovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<mvcmovieContext>>()))

        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Heeramandi",
                    ReleaseDate = DateTime.Parse("2024-05-24"),
                    Genre = "Drama",
                    Price = 5.00M,
                    Rating="R"
                },
                new Movie
                {
                    Title = "Godzilla ",
                    ReleaseDate = DateTime.Parse("1954-11-03"),
                    Genre = "Fantasy",
                    Price = 6.30M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-03-24"),
                    Genre = "Action",
                    Price = 7.00M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Sholay",
                    ReleaseDate = DateTime.Parse("1975-08-15"),
                    Genre = "Action",
                    Price = 8.00M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Uri",
                    ReleaseDate = DateTime.Parse("2019-01-11"),
                    Genre = "Suspense",
                    Price = 6.50M,
                    Rating = "R"
                }
            );
            context.SaveChanges();
        }
    }
}

