using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class Movie
    {
        private string title { get; set; }
        private string director { get; set; }
        private string rating { get; set; }

        public Movie(string aTitle, string aDirector, string aRating)
        {
            this.title = aTitle;
            this.director = aDirector;
            this.Rating = aRating;
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                List<String> clasification =new List<String>{ "P", "PG", "PG-13", "R", "NR" };
                if (clasification.Contains(value)){
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
