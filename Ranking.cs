
namespace Sandbox.ConsoleApp
{
    public class Ranking
    {

        /// <summary>
        /// Blumberg C# Interview
        /// Assuming 2 input parameters.
        /// 1. List Of Char Arrays
        /// 2. Char Array
        /// Need to write a function which will list elements from List Of Char Arrays (param 1) 
        /// That not exist in Array (param 2)
        /// In descending order ranked by number of times element occured in List (param 1) 
        /// Excluding elements with 0-zero counts - means all elements from Array (param 2)
        /// should exixts in each array from List patram 1)
        /// </summary>
        /// <param name="args">Command Line Arguments</param>
        /// 
        public IEnumerable<(char Element, int Rank)> RankElementsByCriteria(List<char[]> listOfArrays, char[] inputArray)
        {
            //get distinnct char from param 1 List
            var allCharacters = listOfArrays.SelectMany(c => c);
            var elements = allCharacters.Except(inputArray).Distinct();

            //produce list of ananimous objects with ranks from elements
            var ranked = elements.Select(chr =>

                new
                {
                    element = chr,
                    rank = allCharacters.Count(c => c == chr)
                }
            )
                .OrderByDescending(c => c.rank)
                .ThenBy(c => c.element)
                .Select(c => (c.element, c.rank))
            ;
            return ranked;

        }

        public int findNumOfChars(string s, char c)
        {
            int result = 0;
            result = s.Count(chr => chr == c);
            return result;
        }
    }
}
