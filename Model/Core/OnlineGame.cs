using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class OnlineGame :Game,  IComputerable, IMobile
    {
        public override string GameMode => "Online";
        public string GetPlatformName() => "PC, Mobile";


        public OnlineGame(string title, string genre, int age, DateTime re, double ratting, string url) : base(title, genre, age, re, ratting, url)
        {

        }




    }
}
