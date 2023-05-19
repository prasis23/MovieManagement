using Microsoft.EntityFrameworkCore;
using MoviManagmentAPI.Models;

namespace MoviManagmentAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieDetails> MoviesDetails { get; set; }
        public DbSet<MovieMedia> MoviesMedia { get; set; }
        public DbSet<MovieRating> movieRatings { get; set; }
        public DbSet<MovieReview> movieReviews { get; set; }
        public DbSet<UserMovieLog> userMoviesLogs { get; set;}
        public DbSet<UserFavourite> UserFavourites { get; set; }
    }
}
