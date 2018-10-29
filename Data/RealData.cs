using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using SpikeReadingJson;

namespace Data
{
    public class RealData : IData
    {
        public List<Rating> jsonToRatingList()
        {
            return JsonConvert.DeserializeObject<IEnumerable<Rating>>(File.ReadAllText(@"ratings.json")).ToList();
        }
    }
}
