using Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Data
{
    public abstract class Serialization
    {
        public abstract void Serialize(string filePath, List<Game> games);
        public abstract List<Game> Deserialize(string filePath);
    }
}
