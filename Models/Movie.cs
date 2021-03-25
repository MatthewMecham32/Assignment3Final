using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3Final.Models
{
    public class Movie
    {
        
        [Key]
        public int MovieID { get; set; }
        [Required(ErrorMessage = "Title is a required field")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Category is a required field")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Year is a required field")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is a required field")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is a required field")]
        public string Rating { get; set; }

        public bool? Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(20)]
        public string Notes { get; set; }

    }
}
