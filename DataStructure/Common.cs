using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class Common
    {
        public static int GetTotalCase(int[] sales)
        {
            int total = 0;
            for (int i = 0; i <= sales.GetUpperBound(0); i++)
            {
                total = total + sales[i];
            }
            return total;
        }

        public static double Middle(double[] a)
        {
            if (a == null || a.Length == 0) return 0;
            if (a.Length == 1) return a[0];
            Array.Sort<double>(a);

            int len = a.Length;
            if (len % 2 != 0)
            {
                return a[len / 2];
            }
            else
            {
                return (a[len / 2 - 1] + a[len / 2]) / 2;
            }
        }
    }
}
