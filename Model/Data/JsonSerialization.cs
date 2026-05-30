using Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json.Linq;

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

        public void Serializeone(string filePath, Game game)
        {
            string file = Path.Combine(filePath, game.Title + ".json");
            JObject jsonGame = new JObject
            {
                { "Title", game.Title },
                { "Genre", game.Genre },
                { "AgeRating", game.AgeRating },
                { "ReleaseDate", game.ReleaseDate.ToString("dd-MM-yyyy") },
                { "Rating", game.Rating },
                { "ImageURL", game.ImageURL },
                { "Type", game.GameMode }
            }   ;

            File.WriteAllText(file, jsonGame.ToString());
        }
        public Game Deserializeone(string filePath)
        {

            if (!File.Exists(filePath))
                return null;

            string jsonText = File.ReadAllText(filePath);
            JObject jsonGame = JObject.Parse(jsonText);

            string title = jsonGame["Title"]?.ToString();
            string genre = jsonGame["Genre"]?.ToString();
            int ageRating = int.Parse(jsonGame["AgeRating"]?.ToString() ?? "0");
            DateTime releaseDate = DateTime.Parse(jsonGame["ReleaseDate"]?.ToString() ?? DateTime.MinValue.ToString());
            double rating = double.Parse(jsonGame["Rating"]?.ToString() ?? "0");
            string imageURL = jsonGame["ImageURL"]?.ToString();
            string type = jsonGame["Type"]?.ToString();

            if (type == "Single")
            {
                return new SingleGame(title, genre, ageRating, releaseDate, rating, imageURL);
            }
            else if (type == "Multiplayer")
            {
                return new MultiplayerGame(title, genre, ageRating, releaseDate, rating, imageURL);
            }
            else if (type == "Online")
            {
                return new OnlineGame(title, genre, ageRating, releaseDate, rating, imageURL);
            }

            return null;
        }
    }
}
