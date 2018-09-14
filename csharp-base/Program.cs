using System;

using DataStructure;
using DesignPatterns;

namespace csharp_base
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 1, 2 };
            int res = ArrayProblem.Duplicate1(ref arr);
            MyWrite(arr);

            string s = "loveleetcode";
            Console.WriteLine(StringProblem.FirstUniqChar(s));

            Console.ReadKey();
            int oriInt = 123;
            Console.WriteLine(StringProblem.RevertInt(oriInt));
            Console.ReadKey();

            var revert = StringProblem.RevertString("hi, i am lucy.");
            Console.WriteLine(revert);
            Console.Read();

            var resArr = ArrayProblem.TwoSum(new int[] { 2, 7, 11, 15 }, 18);
            MyWrite(resArr);

            //int[] arr = new int[] { 1, 1, 2 };
            //int res = ArrayProblem.Duplicate(ref arr);
            //for(int i = 0; i < res; ++i)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            Console.ReadKey();

            Console.WriteLine("斐波拉契数列，第10位");
            Console.WriteLine(Fibonacci.GetSeq(10));
            //Console.ReadKey();

            CStack.Output();
            CArray.Output();

            Console.WriteLine(".....................");
            ScoreArray sa = new ScoreArray();
            sa.scores = new int[] { 99, 89, 88, 78, 55 };
            Console.WriteLine("数组: [99, 89, 88, 78, 55]");
            Console.WriteLine("avg: {0}", sa.GetAvg());
            Console.WriteLine("max: {0}", sa.GetMax());
            Console.WriteLine("min: {0}", sa.GetMin());

            Console.WriteLine(".....................");
            Console.WriteLine("数组：[1, 3, 4, 6, 9]");
            int[] sales = new int[] { 1, 3, 4, 6, 9 };
            Console.WriteLine("和： {0}", Common.GetTotalCase(sales));

            Console.WriteLine(".....................");
            Console.WriteLine("数组：[5, 1, 22, 7,9]");
            double[] a = new double[] { 5, 1, 22, 7, 9 };
            Console.WriteLine("中间数： {0}", Common.Middle(a));

            Console.WriteLine(".....................");
            Console.WriteLine("Fibonacci sequence");
            foreach (long fib in FibonacciGenerator.GetSequence(11))
            {
                Console.WriteLine(fib);
            }
            Console.WriteLine(".....................");
            Console.WriteLine("斐波拉契数列第10位: {0}", Fibonacci.GetSequence(10));

            Console.WriteLine(".....................");
            FactoryDemo();
            Console.ReadKey();
        }

        static void MyWrite(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }

        static void SingletonDemo()
        {
            SingletonLazySafety instance = SingletonLazySafety.GetInstance();
        }

        static void FactoryDemo()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            Shape circle = shapeFactory.GetShape("CIRCLE");
            circle.Draw();

            Shape rectangle = shapeFactory.GetShape("RECTANGLE");
            rectangle.Draw();

            Shape square = shapeFactory.GetShape("SQUARE");
            square.Draw();
        }
    }
}
