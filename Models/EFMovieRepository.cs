using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3Final.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private MovieDBContext _context;

        //Constructor for repsoitory
        public EFMovieRepository(MovieDBContext context)
        {
            _context = context;
        }

        public IQueryable<Movie> Movies => _context.Movies;

    }
}
