using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class ArrayProblem
    {
        public static int Duplicate(ref int[] nums)
        {
            var numList = nums.ToList();
            numList.Sort();
            var cleanList = new List<int>();
            if (numList != null && numList.Count > 0)
            {
                for(int i = 0; i < numList.Count; i++)
                {
                    if (!cleanList.Contains(numList[i]))
                    {
                        cleanList.Add(numList[i]);
                    }
                }
            }
            nums = cleanList.ToArray();
            return nums.Length;

            //nums = nums.Distinct().ToArray();
            //return nums.Length;            
        }

        public static int Duplicate1(ref int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for(int j = 1; j < nums.Length; j ++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                    Array.Clear(nums, j, 1);
                    //nums.ToList().RemoveAt(j)
                }
            }
            var len = i + 1;
            nums = (int[])Redim(nums, 2);
            return i + 1;
        }

        public static Array Redim(Array origArray, int desiredSize)
        {
            //determine the type of element
            Type t = origArray.GetType().GetElementType();
            //create a number of elements with a new array of expectations
            //new array type must match the type of the original array
            Array newArray = Array.CreateInstance(t, desiredSize);
            //copy the original elements of the array to the new array
            Array.Copy(origArray, 0, newArray, 0, Math.Min(origArray.Length, desiredSize));
            //return new array
            return newArray;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }

    }



}
