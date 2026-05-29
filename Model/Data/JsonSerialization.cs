using Model.Core;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Data
{
    public class JsonSerialization : Serialization
    {
        public override void Serialize(string filePath, List<Game> games)
        {
            JArray jsonObject = new JArray();

            foreach (Game game in games)
            {
                JObject jsonGame = new JObject
                {
                    { "Title", game.Title },
                    { "Genre", game.Genre },
                    { "AgeRating", game.AgeRating },
                    { "ReleaseDate", game.ReleaseDate.ToString("dd-MM-yyyy") },
                    { "Rating", game.Rating },
                    { "ImageURL", game.ImageURL },
                    { "Type", game.GameMode }
                };
                jsonObject.Add(jsonGame);
            }
            File.WriteAllText(filePath, jsonObject.ToString());
        }
        public override List<Game> Deserialize(string filePath)
        {
            List<Game> games = new List<Game>();

            if (!File.Exists(filePath)) return games;

            string jsonText = File.ReadAllText(filePath);
            JArray jsonObject = JArray.Parse(jsonText);
            foreach (JObject jsonGame in jsonObject)
            {
                string title = jsonGame["Title"]?.ToString();
                string genre = jsonGame["Genre"]?.ToString();
                int ageRating = int.Parse(jsonGame["AgeRating"]?.ToString() ?? "0");
                DateTime releaseDate = DateTime.Parse(jsonGame["ReleaseDate"]?.ToString() ?? DateTime.MinValue.ToString());
                double rating = double.Parse(jsonGame["Rating"]?.ToString() ?? "0");
                string imageURL = jsonGame["ImageURL"]?.ToString();
                string type = jsonGame["Type"]?.ToString();

                Game game = null;
                if (type == "Single")
                {
                    game = new SingleGame(title, genre, ageRating, releaseDate, rating, imageURL);
                }
                else if (type == "Multiplayer")
                {
                    game = new MultiplayerGame(title, genre, ageRating, releaseDate, rating, imageURL);
                }
                else if (type == "Online")
                {
                    game = new OnlineGame(title, genre, ageRating, releaseDate, rating, imageURL);
                }
                if (game != null) games.Add(game);
            }

            return games;
        }
    }
}
