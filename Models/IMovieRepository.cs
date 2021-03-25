using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3Final.Models
{
    public interface IMovieRepository
    {
        IQueryable<Movie> Movies { get; }
    }
}
