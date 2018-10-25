using System;
using System.IO;
using Newtonsoft.Json;

namespace SpikeReadingJson
{
    class JsonReader
    {
        static void Main(string[] args)
        {
            string json = @"{
            'CPU': 'Intel',
            'PSU': '500W',
            'Drives': [
            'DVD read/writer'
            /*(broken)*/,
            '500 gigabyte hard drive',
            '200 gigabype hard drive'
            ]
            }";

            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }
            }

            Console.ReadLine();
        }
    }
}