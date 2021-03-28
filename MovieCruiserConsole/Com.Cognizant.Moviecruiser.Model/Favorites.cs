using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Cognizant.Moviecruiser.Model
{
    public class Favorites
    {
        private List<Movie> movieList;
        private double total;

        //properties
        public List<Movie> MovieList
        {
            get =>  movieList; 
            set { movieList = value; }
        }
        public double Total
        {
            get =>  total; 
            set { total = value; }
        }

        public Favorites() { }

        //parameterized constructor
        public Favorites(List<Movie> movieList, double total)
        {
            MovieList = movieList;
            Total = total;
        }

        //generate ToString() method
        public override string ToString()
        {
            return base.ToString();
        }

        //generate Equals() method
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
