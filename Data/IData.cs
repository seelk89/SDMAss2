using System.Collections.Generic;
using SpikeReadingJson;

namespace Data
{
    public interface IData
    {
        List<Rating> jsonToRatingList();
    }
}