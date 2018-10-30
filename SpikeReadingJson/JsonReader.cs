using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpikeReadingJson
{
    public class JsonReader
    {
        static void Main(string[] args)
        {
            var timer = DateTime.Now;
            List<Rating> ratingsInList = JsonConvert.DeserializeObject<IEnumerable<Rating>>(File.ReadAllText(@"ratings.json")).ToList();
            Console.WriteLine(timer - DateTime.Now);
        }
    }
}