using System;
using System.Collections.Generic;
using System.Text;
using Com.Cognizant.Moviecruiser.Model;
using Com.Cognizant.Moviecruiser.Utility;

namespace Com.Cognizant.Moviecruiser.Dao
{
    public static class MovieDaoCollectionTest
    {
        public static void TestGetMovieListAdmin()
        {

            MovieDaoCollection menuItemDao = new MovieDaoCollection();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Admin Movie List~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ \n\n Id ||      Title      ||  BoxOffice ||  Active ||  Date of Launch ||     Genre     || Has Teaser ||  Action\n");
            foreach (var item in menuItemDao.GetMovieListAdmin())
            {
                Console.Write(item.Id + "   ");
                Console.Write(item.Title + "   ");
                Console.Write(item.BoxOffice + "  ");
                Console.Write(item.Active ? "Yes   " : "No   ");
                Console.Write(item.DateOfLaunch + "   ");
                Console.Write(item.Genre + "   ");
                Console.Write(item.HasTeaser ? "   Yes" : "   No");
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        public static void TestGetMovieListCustomer()
        {
            MovieDaoCollection movieDao = new MovieDaoCollection();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Customer Movie List~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ \n\n Id ||      Title      ||  BoxOffice ||  Active ||  Date of Launch ||     Genre     || Has Teaser ||  Action\n");
            movieDao.GetMovieListCustomer().ForEach(item => Console.WriteLine($"{item.Id} {item.Title} {item.BoxOffice} {(item.Active ? "Yes" : "No")} {item.DateOfLaunch} {item.Genre} {(item.HasTeaser ? "Yes" : "No")}"));
            Console.WriteLine();
        }
        public static void TestModifyMovie()
        {

            Movie movie = new Movie(id: 2, title: "Godzilla Vs KingKong", boxoffice: "$1234567789", active: true, dateOfLaunch: DateUtility.ConvertToDate("2017/12/23"), genre: "Thriller", hasteaser: true);
            MovieDaoCollection menuItemDao = new MovieDaoCollection();
            menuItemDao.ModifyMovie(movie);


        }
        public static void TestGetMenuItem()
        {
            Console.Write("Enter movie ID to check:");
            long productID = long.Parse(Console.ReadLine());
            MovieDaoCollection movieDao = new MovieDaoCollection();
            movieDao.GetMovie(productID);
        }
    }
}

