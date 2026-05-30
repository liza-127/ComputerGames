using Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public interface IStatistic
    {
        double MaxRating(List<Game> games);
        double MinRating(List<Game> games);
        double AverageRating(List<Game> games);
        double MedianRating(List<Game> games);


    }
}
