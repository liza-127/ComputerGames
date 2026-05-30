using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public abstract class Game
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int AgeRating { get; set; }
        public double Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ImageURL { get; set; }
       

        public abstract string GameMode { get; }

        protected Game(string title, string genre, int age, DateTime re, double ratting, string imageURL)
        {
            Title = title;
            Genre = genre;
            AgeRating = age;
            ReleaseDate = re;
            Rating = ratting;
            ImageURL = imageURL;
        }



    }
}
