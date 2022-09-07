using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDom.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieTitle{ get; set; }
        public string Genre{ get; set; }
        public int ReleaseYear { get; set; }
        public string Ratings { get; set; }
        public Movie()
        {

        }
    }
}
