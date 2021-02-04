using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3Final.Models
{
    public static class TempStorage
    {
        private static List<AppResponse> entries = new List<AppResponse>();

        public static IEnumerable<AppResponse> Entry => entries;

        public static void AddEntry(AppResponse entry)
        {
            entries.Add(entry);
        }
    }
}
