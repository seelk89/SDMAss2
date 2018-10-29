using System;
using Ass2;
using Data;

namespace FunctionsRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //var timer = DateTime.Now;
            IData data = new RealData();
            IRatingFunctions r = new RatingFunctions(data);
            //Console.WriteLine(timer - DateTime.Now);

            var timer2 = DateTime.Now;
            Console.WriteLine(r.TimesReviewerHasGivenRate(1, 1));
            Console.WriteLine("Function took: " + (timer2 - DateTime.Now));
        }
    }
}