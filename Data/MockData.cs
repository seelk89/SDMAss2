using System;
using System.Collections.Generic;
using System.Text;
using SpikeReadingJson;

namespace Data
{
    public class MockData : IData
    {
        public List<Rating> jsonToRatingList()
        {
            List<Rating> mockData = new List<Rating>();
            
            mockData.Add(new Rating()
            {
                Movie = 1,
                Date = "2005-09-06",
                Grade = 1,
                Reviewer = 1
            });
            
            mockData.Add(new Rating()
            {
                Movie = 2,
                Date = "2006-09-06",
                Grade = 2,
                Reviewer = 2
            });
            
            mockData.Add(new Rating()
            {
                Movie = 3,
                Date = "2007-09-06",
                Grade = 3,
                Reviewer = 3
            });

            return mockData;
        }
    }
}
