using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
     public  class SingleGame : Game, IComputerable,  IConsoleable
    {
        public override string GameMode => "Single";
        public string GetPlatformName() => "PC, Console";


        public SingleGame(string title, string genre, int age, DateTime re, double ratting, string url) : base(title, genre, age, re, ratting, url)
        {

        }
    }
}
