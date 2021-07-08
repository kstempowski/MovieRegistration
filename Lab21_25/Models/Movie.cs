using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21_25.Models
{
    public class Movie
    {
        
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Title cannot exceed 50 characters")]
        public string Title { get; set; }
        public string Genre { get; set; }

        [Range(1880, 2021, ErrorMessage = "Movie must have been made between 1880 and 2021")]
        public DateTime Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

    }
}
