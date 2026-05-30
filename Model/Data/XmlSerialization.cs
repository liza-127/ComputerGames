using Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.Data
{
    public class XmlSerialization : Serialization
    {
        public override void Serialize(string filePath, List<Game> games)
        {
        
            List<DTOGame> dtolist = new List<DTOGame>();
            foreach (Game game in games)
            {
                DTOGame dto = new DTOGame(game);
                dtolist.Add(dto);
            }

            var serializer = new XmlSerializer(typeof(List<DTOGame>));
            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, dtolist);
            }
        }
        public override List<Game> Deserialize(string filePath)
        {
            List<Game> games = new List<Game>();

            if (!File.Exists(filePath)) return games;

            List<DTOGame> dtolist;

            var serializer = new XmlSerializer(typeof(List<DTOGame>));
            using (var reader = new StreamReader(filePath))
            {
                dtolist = (List<DTOGame>)serializer.Deserialize(reader);
            }

            if (dtolist == null) return games;
            foreach (var dto in dtolist)
            {
                Game game = null;

                if (dto.Type == "Single")
                {
                    game = new SingleGame(dto.Title, dto.Genre, dto.AgeRating, dto.ReleaseDate, dto.Rating, dto.ImageURL);
                }
                else if (dto.Type == "Multiplayer")
                {
                    game = new MultiplayerGame(dto.Title, dto.Genre, dto.AgeRating, dto.ReleaseDate, dto.Rating, dto.ImageURL);
                }
                else if (dto.Type == "Online")
                {
                    game = new OnlineGame(dto.Title, dto.Genre, dto.AgeRating, dto.ReleaseDate, dto.Rating, dto.ImageURL);
                }
                if (game != null) games.Add(game);
            }

            return games;
        }
        public void Serializeone(string filePath, Game game)
        {
            string file = Path.Combine(filePath, game.Title + ".xml");
            DTOGame dto = new DTOGame(game);

            var serializer = new XmlSerializer(typeof(DTOGame));

            using (var writer = new StreamWriter(file))
            {
                serializer.Serialize(writer, dto);
            }
        }
        public  Game Deserializeone(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            DTOGame dto;

            var serializer = new XmlSerializer(typeof(DTOGame));

            using (var reader = new StreamReader(filePath))
            {
                dto = (DTOGame)serializer.Deserialize(reader);
            }

            if (dto == null)
                return null;

            if (dto.Type == "Single")
            {
                return new SingleGame(dto.Title, dto.Genre, dto.AgeRating,
                    dto.ReleaseDate, dto.Rating, dto.ImageURL);
            }
            else if (dto.Type == "Multiplayer")
            {
                return new MultiplayerGame(dto.Title, dto.Genre, dto.AgeRating,
                    dto.ReleaseDate, dto.Rating, dto.ImageURL);
            }
            else if (dto.Type == "Online")
            {
                return new OnlineGame(dto.Title, dto.Genre, dto.AgeRating,
                    dto.ReleaseDate, dto.Rating, dto.ImageURL);
            }

            return null;
        }





    }
}
