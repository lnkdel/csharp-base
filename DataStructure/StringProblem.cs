using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class StringProblem
    {
        public static string RevertString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string RevertString1(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;
            var charArray = input.ToCharArray();

            char temp;
            for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
            {
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;

            }
            return new string(charArray);
        }

        public static int RevertInt(int x)
        {
            if (x < 0) return x;
            string str = x.ToString();
            if (str.Length == 1) return x;

            var charArray = str.ToCharArray();
            char temp;
            for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
            {
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
            }
            return Convert.ToInt32(new string(charArray));
        }

        public static int FirstUniqChar(string s)
        {
            var charArray = s.ToCharArray();            
            Dictionary<int, char> duplicateDictionary = new Dictionary<int, char>();

            for(int i = 0; i < charArray.Length - 1; i++)
            {
                var temp = charArray[i];                
                if (!duplicateDictionary.Values.Contains(temp))
                {
                    duplicateDictionary.Add(i, temp);
                }
                else
                {
                    foreach (var kv in duplicateDictionary)
                    {
                        if (kv.Value == temp)
                        {
                            return kv.Key;
                        }
                    }
                }
                
            }
            return -1;
        }
    }
}
