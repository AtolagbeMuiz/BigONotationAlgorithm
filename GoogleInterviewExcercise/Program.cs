using System;
using System.Collections.Generic;

namespace GoogleInterviewExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            searchforPairsInAnArrayThatGivesAGivenSum();

            //searchforPairsInAnArrayThatGivesAGivenSum3();
        }

        /// <summary>
        /// This excercise involves writing a function that takes an array and search for a pair in the array 
        /// that when added together gives a given sum
        /// </summary>
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

        public static bool searchforPairsInAnArrayThatGivesAGivenSum3()
        {
            int[] numberArray = { 4, 4, 2, 1 };
            const int sum = 8;

            //-->though process
            //--> loop through the array using nexted for to compare 2 pairs of element if it's a sum
            //ensure the second loop starts from index 1 not 0

            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 1; j < numberArray.Length; j++)
                {
                    var sumValue = numberArray[i] + numberArray[j];

                    if(sumValue == sum)
                    {
                        Console.WriteLine("true");
                        return true;
                    }
                    continue;

                }
            }
            Console.WriteLine("false");
            return false;
        }
    }
}
