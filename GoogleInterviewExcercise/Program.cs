using System;
using System.Collections.Generic;

namespace GoogleInterviewExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            searchforPairsInAnArrayThatGivesAGivenSum();
        }

        public static void searchforPairsInAnArrayThatGivesAGivenSum()
        {
            int[] numberArray = { 1, 2, 4, 4 };
            const int sum = 8;

            // { 1, 2, 4, 4 };
            for (int i = 0; i < numberArray.Length; i++)
            {
                var firstNumber = numberArray[i];
                for (int j = numberArray.Length - 1; j >= 0; j--)
                {
                    var secondNumber = numberArray[j];
                    if ((numberArray[i] + numberArray[j]) == sum)
                    {
                        Console.WriteLine("The pair of number that gives the sum of 8 in the collection is: " +
                            numberArray[i] + " and " + numberArray[j]);
                        //break;
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            
        }

        public static void searchforPairsInAnArrayThatGivesAGivenSum2()
        {
            Dictionary<int, bool> map = new Dictionary<int, bool>();

            //--> Loop through the Array
            //--> Look for a away to store this values so it can be easily summed
            //--> Loop through the second array and sum the value with the data store in the other data structure

            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    var item = numberArray[i];
            //    map.Add(item, true);
            //}
        }
    }
}
