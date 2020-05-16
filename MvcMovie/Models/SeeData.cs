using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public static class SeeData
    {
        public static  void Initialize(IServiceProvider serviceProvider)
        { 
            using (var context = new MvcMovieContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<MvcMovieContext>>()))
            {
                // Look for my movies.
                if (context.Movie.Any())
                {
                    return ; //DB has been Seeded
                }
                context.Movie.AddRange(
                    new Movie 
                    {
                        Title= "when Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M
                    },
                    new Movie 
                    {
                        Title= "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "RR",
                        Price = 8.99M
                    },
                    new Movie 
                    {
                        Title= "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "RRR",
                        Price = 9.99M
                    },
                    new Movie 
                    {
                        Title= "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "Rat",
                        Price = 3.99M
                    }
                 );
                 context.SaveChanges();
              }
            }
    }
}

                
    
    
    
    
    
    
