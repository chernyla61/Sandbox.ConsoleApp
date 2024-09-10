using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.ConsoleApp
{
    public class Singleton
    {
        private static Singleton _singltonObject;

        public  static Singleton getInstance()
        {
            if(_singltonObject == null){
                _singltonObject = new Singleton();
            }
            return _singltonObject;
        }

        private Singleton() { }



        public static IEnumerable<(char Element, int Rank)> RankElementsByCriteria(List<char[]> listOfArrays, char[] inputArray)
        {
            //create a unique set from inputArray
            var inputSet = new HashSet<char>(inputArray);

            //filter out arrays without elements from param 1 array
            var filtArrayList = listOfArrays.Where(arr => inputSet.All(el => arr.Contains(el)));

            //create a unique set of all elements in the ListOfArrays
            var uniqueElements = filtArrayList.SelectMany(arr => arr).Distinct();

            //create a list of ananimous objects with ranks
            var rankedElements = uniqueElements.Select(el => new
            {
                Element = el,
                Rank = filtArrayList.Count(arr => arr.Contains(el))

            })
                .OrderByDescending(x => x.Rank)
                .ThenBy(x => x.Element)
                //create element tuples from ananimous objects
                .Select(x => (x.Element, x.Rank))
            ;

            return rankedElements;
        }
    }



}
