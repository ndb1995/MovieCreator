using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCreator.Data
{
    public class MovieServices
    {
        #region Private members
        private MovieDbContext dbContext;
        #endregion
        #region Constructor
        public MovieServices(MovieDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion
        #region Public methods
        /// <summary>
        /// This method returns the list of product
        /// </summary>
        /// <returns></returns>
        public async Task<List<Movie>> GetMovieAsync()
        {
            return await dbContext.Movie.ToListAsync();
        }
        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Movie> AddMovieAsync(Movie movie)
        {
            try
            {
                dbContext.Movie.Add(movie);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return movie;
        }
        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Movie> UpdateMovieAsync(Movie movie)
        {
            try
            {
                var productExist = dbContext.Movie.FirstOrDefault(m => m.Id == movie.Id);
                if (productExist != null)
                {
                    dbContext.Update(movie);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return movie;
        }
        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public async Task DeleteMovieAsync(Movie movie)
        {
            try
            {
                dbContext.Movie.Remove(movie);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
