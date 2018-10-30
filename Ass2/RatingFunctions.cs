using Data;
using SpikeReadingJson;
using System;
using System.Collections.Generic;

namespace Ass2
{
    public class RatingFunctions : IRatingFunctions
    {
        private readonly IData _data;

        public RatingFunctions(IData RealData)
        {
            _data = RealData;
        }
        //5 On input N, what is the average rate the movie N had received?
        public double AverageRateForSpecificMovie(int movieId)
        { 
            int count = 0;
            int sum = 0;

            foreach (var item in _data.jsonToRatingList())
            {
                if (item.Movie == movieId)
                {
                    sum += item.Grade;
                    count++;
                }
            }
            return sum /= count;
        }

        //2 On input N, what is the average rate that reviewer N had given?
        public double AverageRateFromReviewer(int reviewerId)
        {
            int count = 0;
            int sum = 0;
           
            foreach (var item in _data.jsonToRatingList())
            {
                if (item.Reviewer == reviewerId)
                {  
                    sum += item.Grade;
                    count++;  
                }
            }

            return sum /= count;
        }
        //9 On input N, what is top N of movies? The score of a movie is its average rate.
        public int BestMovie()
        {

            throw new System.NotImplementedException();
        }
        //6 On input N and G, how many times had movie N received grade G?
        public int HowManySpecificGradesForSpecificMovie(int movieId, int grade)
        {
            int count = 0;
 
            foreach (var item in _data.jsonToRatingList())
            {
                if (item.Movie == movieId && item.Grade == grade)
                {
                    count++;
                }
            }
            return count;
        }

        //7 What is the id(s) of the movie(s) with the highest number of top rates (5)?
        public double IdOfMovieWithTheMost5s()
        {
            throw new System.NotImplementedException();
        }

        //8 What reviewer(s) had done most reviews? 
        public int IdOfReviewerWithMostReviews()
        {
            throw new System.NotImplementedException();
        }

        public List<int> ListOfReviewersForSpecificMovie()
        {
            throw new System.NotImplementedException();
        }

        public List<int> MoviesReviewerHasReviewed()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfReviewersForSpecificMovie(int movieId)
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfReviewsFromReviewer(int reviewerId)
        {
            throw new System.NotImplementedException();
        }

        public int TimesReviewerHasGivenRate(int reviewerId, int grade)
        {
            throw new System.NotImplementedException();
        }
    }
}