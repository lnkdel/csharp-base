﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class CStack
    {
        private int p_index;
        private ArrayList list;
        public CStack()
        {
            list = new ArrayList();
            p_index = -1;
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public void Push(object item)
        {
            list.Add(item);
            p_index++;
        }

        public object Pop()
        {
            object obj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return obj;
        }

        public void Clear()
        {
            list.Clear();
            p_index = -1;
        }

        public object Peek()
        {
            return list[p_index];
        }

        public static void Output()
        {
            CStack alist = new CStack();
            string ch;
            //string word = "sees";
            string word = "lnkdel";
            bool isPalindrome = true;
            for (int x = 0; x < word.Length; x++)
                alist.Push(word.Substring(x, 1));
            int pos = 0;
            while (alist.Count > 0)
            {
                ch = alist.Pop().ToString();
                if (ch != word.Substring(pos, 1))
                {
                    isPalindrome = false;
                    break;
                }
                pos++;
            }
            if (isPalindrome)
                Console.WriteLine(word + " is a palindrome.");
            else
                Console.WriteLine(word + " is not a palindrome.");           

        }
    }
}
