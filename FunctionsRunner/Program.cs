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
            Console.WriteLine("TimesReviewerHasGivenRate" + r.TimesReviewerHasGivenRate(1, 1, list));
            Console.WriteLine("Function took: " + (timer2 - DateTime.Now));
            
            var timer3 = DateTime.Now;
            Console.WriteLine("NumberOfReviewsFromReviewer: " + r.NumberOfReviewsFromReviewer(1, list));
            Console.WriteLine("Function took: " + (timer3 - DateTime.Now));
            
            var timer4 = DateTime.Now;
            Console.WriteLine("NumberOfReviewersForSpecificMovie: " + r.NumberOfReviewersForSpecificMovie(1488844, list));
            Console.WriteLine("Function took: " + (timer4 - DateTime.Now));
            
            var timer5 = DateTime.Now;
            Console.WriteLine("MoviesReviewerHasReviewed: ");
            foreach (var item in r.MoviesReviewerHasReviewed(1, list))
            {
                Console.WriteLine("Reviewer: " + item.Reviewer + " Movie: " + item.Movie + " Grade: " + item.Grade + " Date: " + item.Date);
            }
            Console.WriteLine("Function took: " + (timer5 - DateTime.Now));
            
            var timer6 = DateTime.Now;
            Console.WriteLine("ListOfReviewersForSpecificMovie: ");
            foreach (var item in r.ListOfReviewersForSpecificMovie(1488844, list))
            {
                Console.WriteLine("Reviewer: " + item.Reviewer + " Movie: " + item.Movie + " Grade: " + item.Grade + " Date: " + item.Date);
            }
            Console.WriteLine("Function took: " + (timer6 - DateTime.Now));
        }
    }
}