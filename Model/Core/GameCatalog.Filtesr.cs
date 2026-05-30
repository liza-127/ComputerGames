using Model.Core;
using Model.Core.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public partial class GameCatalog
    {
        // сортировка по алфавиту 
        public List<Game> SortGames(List<Game> games)
        {
         
            if (games == null || games.Count == 0) return null;
            List<Game> itog = new List<Game>(games);
            for (int i = 0; i < itog.Count; i++)
            {
                for (int j = 1; j < itog.Count; j++)
                {
                    if (String.Compare(itog[j-1].Title, itog[j].Title) > 0)
                    {
                        (itog[j - 1], itog[j]) = (itog[j], itog[j - 1]);
                    }

                }
            }
            return itog;

        }
        // играовой режим
        public List<Game> SortMode(List<Game> games1 , string mode)
        {
            if (games1 == null || games1.Count == 0) return null;
          
            List<Game> games = SortGames(games1);
            List<Game> itog = new List<Game>();
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].GameMode == mode)
                {
                    itog.Add(games[i]);
                }
               
            }
            return itog;
        }
        // по платформе 
        public List<Game> SortPlatform(List<Game> games1, string platform)
        {
            if (games1 == null || games1.Count == 0) return null;
   
            List<Game> games = SortGames(games1);
            List<Game> itog = new List<Game>();
            for (int i = 0;i < games.Count;i++)
            {
                if (platform == "PC" && games[i] is IComputerable)
                {
                    itog.Add(games[i]);
                }
                 if (platform == "Console" && games[i] is IConsoleable)
                {
                    itog.Add(games[i]);
                }
                 if (platform == "Mobile" && games[i] is IMobile)
                {
                    itog.Add(games[i]);
                }
               

            }
            return itog;
        }

    }
}

