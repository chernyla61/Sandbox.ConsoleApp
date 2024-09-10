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
        /// Excluding elements with 0-zero counts - means all elements from Array (param 2)
        /// should exixts in each array from List patram 1)
        /// </summary>
        /// <param name="args">Command Line Arguments</param>
        static void Main(string[] args)
        {
            var ranking = new Ranking();
            var listOfArrays = new List<char[]>
            {
                new char[] { 'a', 'b', 'c' },
                new char[] { 'd', 'e', 'a' },
                new char[] { 'f', 'g', 'c' },
                new char[] { 'a', 'c', 'e' }
            };

            var inputArray = new char[] { 'a', 'c' };

            var result = ranking.RankElementsByCriteria(listOfArrays, inputArray);
            Console.WriteLine("\n\n Rank Elements By Criteria ....\n\n  ");
            foreach (var item in result)
            {
                Console.WriteLine($"Element: {item.Element}, Count: {item.Rank}");
            }


            Console.WriteLine("\n\n Find characters in string ....\n\n  ");
            string s = "sffgnwfrgsfsfhn";
            char test= 's';
            int n = ranking.findNumOfChars(s, test);
            Console.WriteLine(n);
        }


    }



}
