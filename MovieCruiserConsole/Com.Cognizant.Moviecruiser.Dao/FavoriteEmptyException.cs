using System;

namespace Com.Cognizant.Moviecruiser.Dao
{
    class FavoriteEmptyException : Exception
    {
        private static readonly string DefaultMessage = "Users Favorite is Empty";

        public FavoriteEmptyException() : base(DefaultMessage) { }
        public FavoriteEmptyException(string message) : base(message)
        {

        }
    }
}
