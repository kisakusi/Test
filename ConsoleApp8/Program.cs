using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] digits = {9,9,9,9};
            int[] result = s.PlusOne(digits);
            Console.WriteLine(string.Join("",result));
            Console.WriteLine("test");
            Console.WriteLine("test2");
        }       
    }
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {           
            for(int i = digits.Length-1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                    digits[i] = 0;
            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}
