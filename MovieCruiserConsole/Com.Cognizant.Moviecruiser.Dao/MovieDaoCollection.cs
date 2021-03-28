using System;
using System.Collections.Generic;
using System.Text;
using Com.Cognizant.Moviecruiser.Utility;
using Com.Cognizant.Moviecruiser.Model;

namespace Com.Cognizant.Moviecruiser.Dao
{
    public class MovieDaoCollection : IMovieDao
    {
        private static List<Movie> movieList;


        public MovieDaoCollection()
        {
            if (movieList == null)
            {
                movieList = new List<Movie>();
                movieList.Add(new Movie(id: 1, title: "Avatar            ", boxoffice: " $2,787,965,087", active: true , dateOfLaunch: DateUtility.ConvertToDate("2017/03/15"), genre: "Science Fiction", hasteaser: true));
                movieList.Add(new Movie(id: 2, title: "The Avengers      ", boxoffice: " $1,518,812,988", active: true , dateOfLaunch: DateUtility.ConvertToDate("23/12/2017"), genre: "Superhero      ", hasteaser: false));
                movieList.Add(new Movie(id: 3, title: "Titanic           ", boxoffice: " $2,187,463,944", active: true , dateOfLaunch: DateUtility.ConvertToDate("21/08/2017"), genre: "Romance        ", hasteaser: false));
                movieList.Add(new Movie(id: 4, title: "Jurassic World    ", boxoffice: " $1,671,713,208", active: false, dateOfLaunch: DateUtility.ConvertToDate("02/07/2017"), genre: " Science Fiction", hasteaser: true));
                movieList.Add(new Movie(id: 5, title: "Avengers: End Game", boxoffice: " $2,750,760,348", active: true , dateOfLaunch: DateUtility.ConvertToDate("02/11/2022"), genre: "Superhero      ", hasteaser: true));

            }
        }

        public List<Movie> GetMovieListAdmin()
        {
            return movieList;
        }

        public List<Movie> GetMovieListCustomer()
        {
            List<Movie> custommerMovie = new List<Movie>();
            foreach (Movie item in movieList)
            {
                if (item.DateOfLaunch > DateTime.Now && item.Active == true)
                {
                    custommerMovie.Add(item);
                }

            }
            return custommerMovie;
        }

        public void ModifyMovie(Movie movie)
        {
            foreach (Movie item in movieList)
            {
                if (item.Equals(movie))
                {
                    movieList.Add(item);
                }
            }
        }

        public Movie GetMovie(long movieId)
        {
            List<Movie> getMovie = new List<Movie>();
            foreach (Movie item in movieList)
            {
                if (item.Id == movieId)
                {
                    getMovie.Add(item);

                }
            }
            return getMovie[0];
        }
    }
}
