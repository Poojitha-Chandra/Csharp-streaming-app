using System;
using System.Collections.Generic;
using System.Text;
using Com.Cognizant.Moviecruiser.Model;

namespace Com.Cognizant.Moviecruiser.Dao
{
    public class FavoritesDaoCollectionTest
    {
        public static void TestAddCartItem()
        {
            FavoritesDaoCollection favoriteDao = new FavoritesDaoCollection();
            favoriteDao.AddMovieToFavorites(userId: 1, movieId: 1);

        }
        public static void TestGetAllCartItems()
        {
            FavoritesDaoCollection favoriteDao = new FavoritesDaoCollection();
            Favorites fav = favoriteDao.GetAllMovieFromFavorites(userId: 1);
            Console.WriteLine("Display Added Favorite ");
            fav.MovieList.ForEach(item => Console.WriteLine($"{item.Id} {item.Title} {item.BoxOffice} {(item.Active ? "Yes" : "No")} {item.DateOfLaunch} {item.Genre} {(item.HasTeaser ? "Yes" : "No")}"));
        }
        public static void TestRemoveCartItem()
        {
            Console.WriteLine("\n Favorite Removed from user List");
            FavoritesDaoCollection favDao = new FavoritesDaoCollection();
            favDao.RemoveMovieFromFavorites(userId: 1, productId: 1);
            try
            {

                favDao.GetAllMovieFromFavorites(userId: 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}

