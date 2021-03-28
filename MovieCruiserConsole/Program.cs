using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Moviecruiser.Dao;

namespace MovieCruiserConsole
{
    class Program
    {
        static void Main(string[] args)

        {


            MovieDaoCollectionTest.TestGetMovieListAdmin();
            MovieDaoCollectionTest.TestGetMovieListCustomer();
            MovieDaoCollectionTest.TestModifyMovie();
            // MenuItemDaoCollectionTest.TestGetMenuItem();

            /*    CartDaoCollectionTest.TestAddCartItem();
                CartDaoCollectionTest.TestGetAllCartItems();
                CartDaoCollectionTest.TestRemoveCartItem();*/

            // Test add item to cart
            FavoritesDaoCollectionTest.TestAddCartItem();
        }
    }
}