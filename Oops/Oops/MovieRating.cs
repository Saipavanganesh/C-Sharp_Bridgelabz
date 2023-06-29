using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class MovieRating
    {
        public string name;
        public string director;
        private string rating;
        public MovieRating(string movieName, string movieDirector, string movieRating)
        {
            name = movieName;
            director = movieDirector;
            Rating = movieRating;
        }
        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" ||
                    value == "NR" )
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
