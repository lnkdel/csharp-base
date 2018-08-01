using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class ScoreArray
    {
        public int[] scores { get; set; }

        public ScoreArray()
        {

        }

        public int GetAvg()
        {
            return (int)scores.Average();
        }

        public int GetMax()
        {
            return scores.Max();
        }

        public int GetMin()
        {
            return scores.Min();
        }
    }
}
