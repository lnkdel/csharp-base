using System.Collections.Generic;

namespace DataStructure
{
    public class FibonacciGenerator
    {
        public static IEnumerable<long> GetSequence(int count)
        {
            long fib1 = 0;
            long fib2 = 1;
            yield return fib1;
            yield return fib2;
            while (--count != 1)
            {
                long fib3 = fib1 + fib2;
                yield return fib3;
                fib1 = fib2;
                fib2 = fib3;
            }
        }
    }

    public class Fibonacci
    {
        public static int GetSequence(int count)
        {
            if (count <= 0) return 0;
            else if (count == 1 || count == 2) return 1;
            else
                return GetSequence(count - 1) + GetSequence(count - 2);

        }

        /// <summary>
        /// 面试推荐方法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long GetSeq(int n)
        {
            int[] result = new int[] { 0, 1 };
            if (n < 2)
                return result[n];

            long fibNMinusOne = 1;
            long fibNminusTwo = 0;
            long fibN = 0;
            for(int i = 2; i <= n; ++i)
            {
                fibN = fibNMinusOne + fibNminusTwo;
                fibNminusTwo = fibNMinusOne;
                fibNMinusOne = fibN;
            }
            return fibN;
        }
    }
}
