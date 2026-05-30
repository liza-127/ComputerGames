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
            new SingleGame(
                "Portal",
                "Puzzle",
                12,
                new DateTime(2007, 10, 10),
                9.0,
                "https://upload.wikimedia.org/wikipedia/ru/archive/4/4e/20230901120210%21Portal_boxcover.jpg"),

            new SingleGame(
                "Skyrim",
                "RPG",
                18,
                new DateTime(2011, 11, 11),
                9.4,
                "https://upload.wikimedia.org/wikipedia/en/1/15/The_Elder_Scrolls_V_Skyrim_cover.png"),

            new MultiplayerGame(
                "Terraria",
                "Sandbox",
                12,
                new DateTime(2011, 5, 16),
                8.9,
                "https://i.pinimg.com/736x/07/7d/53/077d53471564546215aaadcf7e89093f.jpg"),

            new MultiplayerGame(
                "Stardew Valley",
                "Simulation",
                6,
                new DateTime(2016, 2, 26),
                9.5,
                "https://upload.wikimedia.org/wikipedia/ru/7/72/Stardew_Valley_Cover_Art.png"),

            new SingleGame(
                "Hollow Knight",
                "Metroidvania",
                12,
                new DateTime(2017, 2, 24),
                9.0,
                "https://upload.wikimedia.org/wikipedia/ru/e/eb/Hollow_Knight.jpg"),

            new SingleGame(
                "Half-Life",
                "Shooter",
                16,
                new DateTime(1998, 11, 19),
                9.6,
                "https://upload.wikimedia.org/wikipedia/ru/e/e5/HLbox.jpg"),

            new SingleGame(
                "Doom",
                "Shooter",
                18,
                new DateTime(2016, 5, 13),
                8.5,
                "https://upload.wikimedia.org/wikipedia/ru/f/fc/Doom_new_cover_art.jpg"),

            new OnlineGame(
                "Valorant",
                "Tactical Shooter",
                16,
                new DateTime(2020, 6, 2),
                8.0,
                "https://www.kinonews.ru/insimgs/2020/poster/poster94404_1.jpg"),

            new OnlineGame(
                "Overwatch",
                "Hero Shooter",
                12,
                new DateTime(2016, 5, 24),
                8.1,
                "https://static0.gamerantimages.com/wordpress/wp-content/uploads/2024/12/mixcollage-24-dec-2024-11-08-am-494.jpg?q=70&fit=contain&w=1200&dpr=1"),

            new OnlineGame(
                "Fortnite",
                "Battle Royale",
                12,
                new DateTime(2017, 7, 21),
                8.5,
                "https://i.playground.ru/i/pix/3496394/image.jpg"),

            new OnlineGame(
                "Apex Legends",
                "Battle Royale",
                16,
                new DateTime(2019, 2, 4),
                8.9,
                "https://upload.wikimedia.org/wikipedia/ru/1/17/%D0%9E%D0%B1%D0%BB%D0%BE%D0%B6%D0%BA%D0%B0_Apex_Legends.jpg"),

            new OnlineGame(
                "Rust",
                "Survival",
                18,
                new DateTime(2018, 2, 8),
                8.0,
                "https://gfn.ru/media/images/box_art_image-rust-5126d044.original.jpg"),

            new MultiplayerGame(
                "Among Us",
                "Party",
                7,
                new DateTime(2018, 6, 15),
                7.5,
                "https://upload.wikimedia.org/wikipedia/en/9/9a/Among_Us_cover_art.jpg"),

            new MultiplayerGame(
                "Rocket League",
                "Sports",
                0,
                new DateTime(2015, 7, 7),
                8.6,
                "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Rocket_League_coverart.jpg/960px-Rocket_League_coverart.jpg"),

            new MultiplayerGame(
                "Fall Guys",
                "Platformer",
                3,
                new DateTime(2020, 8, 4),
                8.0,
                "https://upload.wikimedia.org/wikipedia/ru/thumb/e/ef/%D0%9E%D0%B1%D0%BB%D0%BE%D0%B6%D0%BA%D0%B0_Fall_Guys.jpg/500px-%D0%9E%D0%B1%D0%BB%D0%BE%D0%B6%D0%BA%D0%B0_Fall_Guys.jpg")
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
