using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpikeReadingJson
{
    class JsonReader
    {
        static void Main(string[] args)
        {
            string bla = "[{\"Reviewer\":1, \"Movie\":1488844, \"Grade\":3, \"Date\":'2005-09-06'}]";

            //List<string> ratings = JsonConvert.DeserializeObject<List<string>>(bla);

            //JsonConvert.DeserializeObject<List<Rating>>(bla);
            
            var timer = DateTime.Now;
            Console.WriteLine(timer);
            using (StreamReader r = new StreamReader("ratings.json"))
            {
                List<string> ratings = JsonConvert.DeserializeObject<List<string>>(bla);
            }
            Console.WriteLine(DateTime.Now - timer);
        }
    }
}