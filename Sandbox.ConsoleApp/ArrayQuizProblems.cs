using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.ConsoleApp
{
    public class ArrayQuizProblems
    {

        public int FindMaxDifference(int[] numbers)
        {
            if (numbers.Length < 2)
                throw new System.IndexOutOfRangeException();
            
            int min = numbers[0];
            int diff = int.MinValue;

            for (int i = 1; i < numbers.Length; i++)
            {
                min = Math.Min(numbers[i], min);
                diff = Math.Max(diff, numbers[i] - min);
            }
            return diff;
        }

        // check if second string has characters and secuence from first string subsequence
        public bool IsSubsequence( string str1,string str2)
        {
            if (string.IsNullOrEmpty(str2)) return true;

            int j = 0;
            foreach (var chr in str1)
            {
                if (chr == str2[j])
                {
                    j++;  // Increment j only after a match
                    if (j == str2.Length) return true;
                    
                }
            }
            return false;
        }






    }
}
