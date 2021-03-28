using System;
using System.Collections.Generic;
using System.Text;
using Com.Cognizant.Moviecruiser.Model;
using Com.Cognizant.Moviecruiser.Utility;

namespace Com.Cognizant.Moviecruiser.Dao
{
    class FavoritesDaoCollection : IFavoritesDao
    {
        private static Dictionary<long, Favorites> userFavorite;

        //constructor
        public FavoritesDaoCollection()
        {
            if (userFavorite == null)
            {
                userFavorite = new Dictionary<long, Favorites>();

            }
        }

        public void AddMovieToFavorites(long userId, long movieId)
        {
            MovieDaoCollection movieDao = new MovieDaoCollection();
            Movie movie = movieDao.GetMovie(movieId);

            if (userFavorite.ContainsKey(userId))
            {
                userFavorite[userId].MovieList.Add(movie);
            }
            else
            {
                List<Movie> movieList = new List<Movie>() { movie };
                userFavorite.Add(userId, new Favorites(movieList, 0));
            }

        }

        public Favorites GetAllMovieFromFavorites( long userId)
        {
            var movieList = userFavorite[userId];
            if (movieList.MovieList.Count.Equals(0))
            {
                throw new FavoriteEmptyException();
            }
            return movieList;


        }

        public void RemoveMovieFromFavorites(long userId, long productId)
        {
            List<Movie> movie = userFavorite[userId].MovieList;
            foreach (Movie item in movie)
            {
                if (item.Id.Equals(productId))
                {
                    userFavorite[userId].MovieList.Remove(item);
                    break;
                }
            }
        }
    }
}
