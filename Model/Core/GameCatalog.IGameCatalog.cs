using Model.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
   public partial class GameCatalog: IGameCatalog
    {
        public void Add(Game game)
        {
            if (game != null && !_games.Exists(g => g.Title == game.Title))
            {
                _games.Add(game);
            }
        }
        public void Add(IEnumerable<Game> games)
        {
            if (games == null) return;
            foreach (var game in games)
            {
                Add(game);
            }
        }
        public void Remove(Game game)
        {
            if (game != null && _games.Exists(g => g.Title == game.Title))
            {
                _games.Remove(game);
            }
        }

    }
}
