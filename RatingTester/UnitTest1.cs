using Ass2;
using System;
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


            Assert.True(r.NumberOfReviewsFromReviewer(3) == 2);
        }
    }
}
