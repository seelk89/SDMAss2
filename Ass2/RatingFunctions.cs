using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;
using Data;
using SpikeReadingJson;
using System.Linq;

namespace Ass2
{
    public class RatingFunctions : IRatingFunctions
    {
        private readonly IData _data;
        
        public RatingFunctions(IData RealData)
        {
            _data = RealData;
        }
        
        public double AverageRateForSpecificMovie(int movieId)
        {
            throw new System.NotImplementedException();
        }

        public double AverageRateFromReviewer(int reviewerId)
        {

            throw new System.NotImplementedException();
        }

        public int BestMovie()
        {
            throw new System.NotImplementedException();
        }

        public int HowManySpecificGradesForSpecificMovie(int movieId, int grade)
        {
            throw new System.NotImplementedException();
        }

        public double IdOfMovieWithTheMost5s()
        {
            throw new System.NotImplementedException();
        }

        public int IdOfReviewerWithMostReviews()
        {
            throw new System.NotImplementedException();
        }
        
        //Jesper
        
        //11 On input N, what are the reviewers that have reviewed movie N? 
        //The list should be sorted decreasing by rate first, and date secondly.
        public List<Rating> ListOfReviewersForSpecificMovie(int movieId, List<Rating> ratingsList)
        {
            List<Rating> listOfReviewers = new List<Rating>();
            foreach (var item in ratingsList)
            {
                if (item.Movie == movieId)
                {
                    listOfReviewers.Add(item);
                }
            }

            listOfReviewers = listOfReviewers.OrderBy(r => r.Grade).ThenBy(r => r.Date).ToList();
            
            return listOfReviewers;
        }

        //10 On input N, what are the movies that reviewer N has reviewed?
        //The list should be sorted decreasing by rate first, and date secondly.
        public List<Rating> MoviesReviewerHasReviewed(int reviewer, List<Rating> ratingsList)
        {
            List<Rating> listOfMovies = new List<Rating>();
            foreach (var item in ratingsList)
            {
                if (item.Reviewer == reviewer)
                {
                    listOfMovies.Add(item);
                }
            }

            listOfMovies = listOfMovies.OrderBy(r => r.Grade).ThenBy(r => r.Date).ToList();

            return listOfMovies;
        }

        //4 On input N, how many have reviewed movie N?
        public int NumberOfReviewersForSpecificMovie(int movieId, List<Rating> ratingsList)
        {
            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            foreach (var item in ratingsList)
            {  
                if (item.Movie == movieId)
                {
                    if (!hashMap.ContainsKey(item.Reviewer))
                    {
                        hashMap.Add(item.Reviewer, item.Movie);
                    } 
                }
            }
            
            return hashMap.Count;
        }

        //1 On input N, what are the number of reviews from reviewer N?
        public int NumberOfReviewsFromReviewer(int reviewerId, List<Rating> ratingsList)
        {
            int count = 0;
            foreach (var item in ratingsList)
            {
                if (item.Reviewer == reviewerId)
                {
                    count++;
                }
            }
            
            return count;
        }

        //3 On input N and G, how many times has reviewer N given a movie grade G?
        public int TimesReviewerHasGivenRate(int reviewerId, int grade, List<Rating> ratingsList)
        {
            int count = 0;
            foreach (var item in ratingsList)
            {
                if (item.Reviewer == reviewerId && item.Grade == grade)
                {
                    count++;
                }
            }
            
            return count;
        }
    }
}