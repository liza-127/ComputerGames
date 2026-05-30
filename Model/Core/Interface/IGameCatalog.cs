using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core.Interface
{
    public interface IGameCatalog
    {
        void Add(Game game);
        void Remove(Game game);


    }
}
