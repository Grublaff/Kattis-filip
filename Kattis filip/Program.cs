using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_filip
{
    internal class Program
    {
        private static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");
            List<int> list = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                string temp = input[i];
                char[] charArray = temp.ToCharArray();
                Array.Reverse(charArray);
                temp = new string(charArray);
                list.Add(Int32.Parse(temp));
            }
            list.Sort();
            Console.WriteLine(list[1]);
        }
    }
}