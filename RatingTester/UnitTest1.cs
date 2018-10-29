using Ass2;
using Data;
using SpikeReadingJson;
using System;
using System.Collections.Generic;
using Xunit;

namespace RatingTester
{
    public class UnitTest1
    {
        [Fact]
        public void NumberOfReviewsFromReviewerTest1()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IRatingFunctions r = new RatingFunctions();
            IData data = new MockData();
            List<Rating> list = data.jsonToRatingList();

            Assert.True(list.Count == 0);

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

            Assert.True(list.Count == 3);
            //Assert.True(r.NumberOfReviewsFromReviewer(1) == 2);
        }

        [Fact]
        public void AverageRateFromReviewerTest2()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IRatingFunctions r = new RatingFunctions();


            Assert.True(r.AverageRateFromReviewer(5) == 2);
        }

        [Fact]
        public void TimesReviewerHasGivenRateTest3()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IRatingFunctions r = new RatingFunctions();


            Assert.True(r.TimesReviewerHasGivenRate(5, 3) == 2);
        }

        [Fact]
        public void NumberOfReviewersForSpecificMovieTest4()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IRatingFunctions r = new RatingFunctions();


            Assert.True(r.NumberOfReviewersForSpecificMovie(5) == 2);
        }

        [Fact]
        public void AverageRateForSpecificMovieTest5()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IRatingFunctions r = new RatingFunctions();


            Assert.True(r.AverageRateForSpecificMovie(5) == 2);
        }

        [Fact]
        public void HowManySpecificGradesForSpecificMovieTest6()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IRatingFunctions r = new RatingFunctions();


            Assert.True(r.HowManySpecificGradesForSpecificMovie(5, 5) == 2);
        }


        [Fact]
        public void IdOfMovieWithTheMost5sTest7()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IRatingFunctions r = new RatingFunctions();


            Assert.True(r.IdOfMovieWithTheMost5s() == 2);
        }

        [Fact]
        public void IdOfReviewerWithMostReviewsTest8()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IRatingFunctions r = new RatingFunctions();


            Assert.True(r.IdOfReviewerWithMostReviews() == 2);
        }

        [Fact]
        public void BestMovieTest9()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IRatingFunctions r = new RatingFunctions();


            Assert.True(r.BestMovie() == 2);
        }

        [Fact]
        public void MoviesReviewerHasReviewedTest10()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IRatingFunctions r = new RatingFunctions();


          //  Assert.True(r.MoviesReviewerHasReviewed() == listttt);
        }

        [Fact]
        public void ListOfReviewersForSpecificMovieTest11()
        {
            // int NumberOfReviewsFromReviewer(int reviewerId);
            IRatingFunctions r = new RatingFunctions();


            //Assert.True(r.ListOfReviewersForSpecificMovie() == listt);
        }
    }
}
