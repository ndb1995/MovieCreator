using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MovieCreator.Data
{
    public class MovieDbContext : DbContext
    {
        #region Contructor
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }
        #endregion

        #region Public properties
        public DbSet<Movie> Movie { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(GetMovies());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shawshank Redemption", Rating = 10.0, Description ="My favorite movie"},
                new Movie { Id = 2, Name = "Weekend at Bernies", Rating = 8.0, Description ="Stupidly funny"},
                new Movie { Id = 3, Name = "The Matrix", Rating = 9.1, Description ="Interesting movie"},
                new Movie { Id = 4, Name = "Airplane!", Rating = 8.7, Description ="Lot of classic jokes"}
            };
        }
        #endregion
    }
}
