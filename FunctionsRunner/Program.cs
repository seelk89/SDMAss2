using System;
using Ass2;
using Data;

namespace FunctionsRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = DateTime.Now;
            IData data = new RealData();
            IRatingFunctions r = new RatingFunctions(data);
            var list = data.jsonToRatingList();
            Console.WriteLine("Time to read the file: " + (timer - DateTime.Now));

            var timer2 = DateTime.Now;
            Console.WriteLine(r.TimesReviewerHasGivenRate(1, 1, list));
            Console.WriteLine("Function took: " + (timer2 - DateTime.Now));
            
            var timer3 = DateTime.Now;
            Console.WriteLine(r.NumberOfReviewsFromReviewer(1, list));
            Console.WriteLine("Function took: " + (timer3 - DateTime.Now));
        }
    }
}