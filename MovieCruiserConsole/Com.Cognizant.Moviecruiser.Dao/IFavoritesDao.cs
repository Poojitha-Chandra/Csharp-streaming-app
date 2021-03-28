using System;
using System.Collections.Generic;
using System.Text;
using Com.Cognizant.Moviecruiser.Model;

namespace Com.Cognizant.Moviecruiser.Dao
{
    interface IFavoritesDao
    {
        void AddMovieToFavorites(long userId, long movieId);
        Favorites GetAllMovieFromFavorites(long userId); 
        void RemoveMovieFromFavorites(long userId, long movieId);
    }
}
