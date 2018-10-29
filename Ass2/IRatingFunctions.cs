using System.Collections.Generic;

namespace Ass2
{
    public interface IRatingFunctions
    {
        //1 On input N, what are the number of reviews from reviewer N?
        int NumberOfReviewsFromReviewer(int reviewerId);

        //2 On input N, what is the average rate that reviewer N had given?
        double AverageRateFromReviewer(int reviewerId);

        //3 On input N and G, how many times has reviewer N given a movie grade G?
        int TimesReviewerHasGivenRate(int reviewerId, int grade);

        //4 On input N, how many have reviewed movie N?
        int NumberOfReviewersForSpecificMovie(int movieId);

        //5 On input N, what is the average rate the movie N had received?
        double AverageRateForSpecificMovie(int movieId);

        //6 On input N and G, how many times had movie N received grade G?
        int HowManySpecificGradesForSpecificMovie(int movieId, int grade);

        //7 What is the id(s) of the movie(s) with the highest number of top rates (5)?
        //plural!!!
        double IdOfMovieWithTheMost5s();

        //8 What reviewer(s) had done most reviews? 
        //plural!!!
        int IdOfReviewerWithMostReviews();

        //9 On input N, what is top N of movies? The score of a movie is its average rate.
        //input?
        int BestMovie();

        //10 On input N, what are the movies that reviewer N has reviewed?
        //The list should be sorted decreasing by rate first, and date secondly.
        List<int> MoviesReviewerHasReviewed();

        //11 On input N, what are the reviewers that have reviewed movie N? 
        //The list should be sorted decreasing by rate first, and date secondly.
        List<int> ListOfReviewersForSpecificMovie();
    }
}