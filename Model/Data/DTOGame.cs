using System;
using System.Collections.Generic;
using System.Text;
using Model.Core;

namespace Model.Data
{
    public class DTOGame
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int AgeRating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Rating { get; set; }
        public string ImageURL { get; set; }
        public string Type { get; set; }

        public DTOGame() { }
        public DTOGame(Game game)
        {
            Title = game.Title;
            Genre = game.Genre;
            AgeRating = game.AgeRating;
            ReleaseDate = game.ReleaseDate;
            Rating = game.Rating;
            ImageURL = game.ImageURL;
            Type = game.GameMode;
        }
    }
}
