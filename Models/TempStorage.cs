using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3Final.Models
{
    public static class TempStorage
    {
        private static List<Movie> entries = new List<Movie>();

        public static IEnumerable<Movie> Entry => entries;

        public static void AddEntry(Movie entry)
        {
            entries.Add(entry);
        }
    }
}
