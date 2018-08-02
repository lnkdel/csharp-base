using System.Linq;

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
