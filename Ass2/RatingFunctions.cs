using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.ComTypes;
using Data;
using SpikeReadingJson;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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

        //7 What is the id(s) of the movie(s) with the highest number of top rates (5)?
        public List<int> IdOfMovieWithTheMost5s(List<Rating> ratingsList)
        {
            Dictionary<int, int> movieIdAnd5Count = new Dictionary<int, int>();
            foreach (var item in ratingsList)
            {  
                if (!movieIdAnd5Count.ContainsKey(item.Movie) && item.Grade == 5)
                {
                    movieIdAnd5Count.Add(item.Movie, 1);
                }
                else if (movieIdAnd5Count.ContainsKey(item.Movie))
                {
                    movieIdAnd5Count[item.Movie] = movieIdAnd5Count[item.Movie] + 1;
                }
            }

            List<int> listOfMoviesWithMost5 = new List<int>();
            var found = movieIdAnd5Count.Max(x => x.Value);
            foreach (var item in movieIdAnd5Count)
            {
                if (item.Value == found)
                {
                    listOfMoviesWithMost5.Add(item.Key);
                }
            }
            
            return listOfMoviesWithMost5;
        }

        public int IdOfReviewerWithMostReviews()
        {
            throw new System.NotImplementedException();
        }
        
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