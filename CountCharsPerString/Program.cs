using System;
using System.Collections.Generic;

namespace CountCharsPerString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "one", "two", "three" };
            List<int> intList = new();
            int i = 0;
            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    i++;
                }
                intList.Add(i);
                i = 0;
            }
            Print(intList);
        }

        private static void Print(List<int> intList)
        {
            foreach (var stringCount in intList)
            {
                Console.WriteLine(stringCount);
            }
        }
    }
}
