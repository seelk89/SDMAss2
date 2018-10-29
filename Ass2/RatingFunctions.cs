using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;
using Data;
using SpikeReadingJson;

namespace Ass2
{
    public class RatingFunctions : IRatingFunctions
    {
        private readonly IData _data;
        private readonly List<Rating> _ratingsList;
        
        public RatingFunctions(IData RealData)
        {
            _data = RealData;
            _ratingsList = _data.jsonToRatingList();
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
        //Here
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
            int count = 0;
            foreach (var item in _ratingsList)
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