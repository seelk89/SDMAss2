using System;
using System.Collections.Generic;
using System.Text;
using SpikeReadingJson;

namespace Data
{
    public class MockData : IData
    {
        List<Rating> mockData = new List<Rating>();
        
        public List<Rating> jsonToRatingList()
        {
            return mockData;
        }

        public void fillList()
        {
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
        }
    }
}
