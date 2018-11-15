using Ass2;
using Data;
using SpikeReadingJson;
using System;
using System.Collections.Generic;
using Xunit;

namespace RatingTester
{
    //Stuff
    public class UnitTest1
    {
        [Fact]
        public void NumberOfReviewsFromReviewerTest1()
        {
            IData data = new MockData();
            IRatingFunctions r = new RatingFunctions(data);
            
            var list = data.jsonToRatingList();

            list.Add(new Rating() {
                Movie = 1,
                Grade = 1,
                Reviewer = 1,
                Date = "2009-10-10"
            });
            list.Add(new Rating()
            {
                Movie = 1,
                Grade = 1,
                Reviewer = 1,
                Date = "2009-10-11"
            });

            list.Add(new Rating()
            {
                Movie = 1,
                Grade = 1,
                Reviewer = 2,
                Date = "2009-10-12"
            });

            Assert.True(r.NumberOfReviewsFromReviewer(1, list) == 2);
        }

        [Fact]
        public void AverageRateFromReviewerTest2()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IData data = new MockData();
            IRatingFunctions r = new RatingFunctions(data);


            Assert.True(r.AverageRateFromReviewer(5) == 2);
        }

        [Fact]
        public void TimesReviewerHasGivenRateTest3()
        {
            IData data = new MockData();
            IRatingFunctions r = new RatingFunctions(data);

            data.fillList();
            var list = data.jsonToRatingList();
            
            Assert.True(r.TimesReviewerHasGivenRate(1, 1, list) == 1);
        }

        [Fact]
        public void NumberOfReviewersForSpecificMovieTest4()
        {
            IData data = new MockData();
            IRatingFunctions r = new RatingFunctions(data);

            data.fillList();
            var list = data.jsonToRatingList();
            
            Assert.True(r.NumberOfReviewersForSpecificMovie(1, list) == 1);
        }

        [Fact]
        public void AverageRateForSpecificMovieTest5()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IData data = new MockData();
            IRatingFunctions r = new RatingFunctions(data);


            Assert.True(r.AverageRateForSpecificMovie(5) == 2);
        }

        [Fact]
        public void HowManySpecificGradesForSpecificMovieTest6()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IData data = new MockData();
            IRatingFunctions r = new RatingFunctions(data);


            Assert.True(r.HowManySpecificGradesForSpecificMovie(5, 5) == 2);
        }


        [Fact]
        public void IdOfMovieWithTheMost5sTest7()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IData data = new MockData();
            IRatingFunctions r = new RatingFunctions(data);


            Assert.True(r.IdOfMovieWithTheMost5s() == 2);
        }
        
        [Fact]
        public void IdOfReviewerWithMostReviewsTest8()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IData data = new MockData();
            IRatingFunctions r = new RatingFunctions(data);


            Assert.True(r.IdOfReviewerWithMostReviews() == 2);
        }

        [Fact]
        public void BestMovieTest9()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IData data = new MockData();
            IRatingFunctions r = new RatingFunctions(data);


            Assert.True(r.BestMovie() == 2);
        }

        [Fact]
        public void MoviesReviewerHasReviewedTest10()
        {
            IData data = new MockData();
            IRatingFunctions r = new RatingFunctions(data);

            data.fillList();
            var list = data.jsonToRatingList();
            
            Assert.True(r.MoviesReviewerHasReviewed(1, list).Count == 1);
        }

        [Fact]
        public void ListOfReviewersForSpecificMovieTest11()
        {
            IData data = new MockData();
            IRatingFunctions r = new RatingFunctions(data);

            data.fillList();
            var list = data.jsonToRatingList();
            
            Assert.True(r.ListOfReviewersForSpecificMovie(1, list).Count == 1);
        }
    }
}
