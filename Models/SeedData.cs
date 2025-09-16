using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(

                new Movie
                {
                    Photo ="https://tse1.mm.bing.net/th/id/OIP.HsBRitTHTPgXwMPyA_hvtgHaK-?rs=1&pid=ImgDetMain&o=7&rm=3" ,
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "****",
                    URL = "https://tse1.mm.bing.net/th/id/OIP.HsBRitTHTPgXwMPyA_hvtgHaK-?rs=1&pid=ImgDetMain&o=7&rm=3"
                },
                new Movie
                {
                    Photo = "https://tse1.mm.bing.net/th/id/OIP.HsBRitTHTPgXwMPyA_hvtgHaK-?rs=1&pid=ImgDetMain&o=7&rm=3",

                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "***",
                    URL = "https://tse1.mm.bing.net/th/id/OIP.HsBRitTHTPgXwMPyA_hvtgHaK-?rs=1&pid=ImgDetMain&o=7&rm=3"


                },
                new Movie
                {
                    Photo = "https://tse1.mm.bing.net/th/id/OIP.HsBRitTHTPgXwMPyA_hvtgHaK-?rs=1&pid=ImgDetMain&o=7&rm=3",
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "****",
                    URL = "https://tse1.mm.bing.net/th/id/OIP.HsBRitTHTPgXwMPyA_hvtgHaK-?rs=1&pid=ImgDetMain&o=7&rm=3"


                },
                new Movie
                {
                    Photo = "https://tse1.mm.bing.net/th/id/OIP.HsBRitTHTPgXwMPyA_hvtgHaK-?rs=1&pid=ImgDetMain&o=7&rm=3",
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "*",
                    URL = "https://tse1.mm.bing.net/th/id/OIP.HsBRitTHTPgXwMPyA_hvtgHaK-?rs=1&pid=ImgDetMain&o=7&rm=3"


                }
            );
            context.SaveChanges();
        }
    }
}
