using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.ConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Blumberg C# Interview
        /// Assuming 2 input parameters.
        /// 1. List Of Char Arrays
        /// 2. Char Array
        /// Need to write a function which will list elements from List (param 1) 
        /// That not exist in Array (param 2)
        /// In descending order ranked by number of times element occured in List (param 1) 
        /// Excluding elements with 0-zero counts. 
        /// </summary>
        /// <param name="args">Command Line Arguments</param>
        static void Main(string[] args)
        {
            List<char[]> listOfArrays = new List<char[]>
        {
            new char[] { 'a', 'b', 'c' },
            new char[] { 'd', 'e', 'a' },
            new char[] { 'f', 'g', 'c' },
            new char[] { 'a', 'c', 'e' }
        };

            char[] inputArray = new char[] { 'a', 'c' };

            //var result = RankElementsByCriteria(listOfArrays, inputArray);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Element: {item.Element}, Count: {item.Rank}");
            //}

            string s = "sffgnwfrgsfsfhn";
            char test= 's';
            int n = findNumOfChars(s, test);
            Console.WriteLine(n);
        }

        public static IEnumerable<(char Element, int Rank)> RankElementsByCriteria(List<char[]> listOfArrays, char[] inputArray)
        {
            //create a unique set from inputArray
            var inputSet = new HashSet<char>(inputArray);

            //filter out arrays without elements fron param 1 array
            var filtArrayList = listOfArrays.Where(arr => inputSet.All(el => arr.Contains(el)));

            //create a unique set of all elements in the ListOfArrays
            var uniqueElements = filtArrayList.SelectMany(arr => arr).Distinct();

            //create a list of element tuples with ranks
            var rankedElements = uniqueElements.Select(el => new
                {
                    Element = el,
                    Rank = filtArrayList.Count(arr => arr.Contains(el))

                })
                .OrderByDescending(x=> x.Rank)
                .ThenBy(x=> x.Element)
                //create element tuples from ananimous objects
                .Select(x=> (x.Element, x.Rank))
            ;

            return rankedElements;
        }


        public static int findNumOfChars(string s, char c)
        {
            var result = 0;

             result =s.Count(chr => chr == c);

            return result;
        }

    }



}
