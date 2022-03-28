using MinimalJWT.Models;

namespace MinimalJWT.Services
{
    public interface IMovieService
    {
        public Movie Create(Movie movie);
        public Movie Get(int id);
        public List<Movie> List();
        public bool Delete(int id);
        public Movie Update(Movie movie);

    }
}
