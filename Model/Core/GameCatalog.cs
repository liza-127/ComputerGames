using Model.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
   public partial class GameCatalog
    {
        
        private List<Game> _games = new()
        {
            new MultiplayerGame(
                "Dota 2",
                "MOBA",
                12,
                new DateTime(2013, 7, 9),
                8,
                "https://example.com/dota2.jpg"),

            new OnlineGame(
                "World of Warcraft",
                "MMORPG",
                12,
                new DateTime(2004, 11, 23),
                9.1,
                "https://example.com/wow.jpg"),

            new SingleGame(
                "The Witcher 3",
                "RPG",
                18,
                new DateTime(2015, 5, 19),
                9.8,
                "https://example.com/witcher3.jpg"),
            new MultiplayerGame(
                "Beawl Stars",
                "MOBAA",
                5,
                new DateTime(2009, 8, 10),
                2,
                "https://example.com/dota2.jpg"),
        };
        public List<Game> GetAllGames()
        {
            return _games;
        }


        public GameCatalog()
        {

        }


    }
  



}
