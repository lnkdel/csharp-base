using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
