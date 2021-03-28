using System;
using System.Collections.Generic;
using System.Text;
using Com.Cognizant.Moviecruiser.Model;

namespace Com.Cognizant.Moviecruiser.Dao
{
    interface IMovieDao
    {
        List<Movie> GetMovieListAdmin();
        List<Movie> GetMovieListCustomer();
        void ModifyMovie(Movie movie);
        Movie GetMovie(long movieId);
    }

}
