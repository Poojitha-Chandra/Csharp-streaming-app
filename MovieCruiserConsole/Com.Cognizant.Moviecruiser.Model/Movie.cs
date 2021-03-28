using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Cognizant.Moviecruiser.Model
{
    public class Movie
    {
        private long _id;
        private string _title;
        private string _boxoffice;
        private bool _active;
        private DateTime _dateOfLaunch;
        private string _genre;
        private bool _hasteaser;

        //properties
        public long Id
        {
            get =>  _id; 
            set { _id = value; }
        }
        public string Title
        {
            get => _title; 
            set { _title = value; }
        }
        public string BoxOffice
        {
            get =>  _boxoffice; 
            set { _boxoffice = value; }
        }
        public bool Active
        {
            get =>  _active; 
            set { _active = value; }
        }
        public DateTime DateOfLaunch
        {
            get =>  _dateOfLaunch; 
            set { _dateOfLaunch = value; }
        }
        public string Genre
        {
            get =>  _genre; 
            set { _genre = value; }
        }
        public bool HasTeaser
        {
            get =>  _hasteaser; 
            set { _hasteaser = value; }
        }
        public Movie() { }

        // parameterized constructor
        public Movie(long id, string title, string boxoffice, bool active, DateTime dateOfLaunch, string genre, bool hasteaser)
        {
            this.Id = id;
            this.Title = title;
            this.BoxOffice = boxoffice;
            this.Active = active;
            this.DateOfLaunch = dateOfLaunch;
            this.Genre = genre;
            this.HasTeaser = hasteaser;
        }

        //generated ToString() method
        public override string ToString()
        {
            return base.ToString();
        }

        //generated Equals() method
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}
