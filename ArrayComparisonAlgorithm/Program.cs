using System;
using System.Collections.Generic;

namespace ArrayComparisonAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // CompareArrays();
             CompareArrays2();

            //compareArrays3();
        }


        public static bool CompareArrays()
        {
            //Given two Arrays, Create a function that let user know (true/false)
            //whether these 2 arrays contains any commin items


            //list the Arrays
            //loop through the first array 
            //then compare each value in the first array while looping throug second array
            //if equal; break the loop, return true
            // otherwise eturn false 

            int[] firstArray = { 1, 2, 3 }; //O(n)
            int[] secondArray = { 5, 7, 6 }; //O(n)

            for (int i = 0; i < firstArray.Length; i++) //O(n)
            {
                for (int j = 0; j < secondArray.Length; j++) //O(n)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        Console.WriteLine("True");
                        return true;
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            Console.WriteLine("False");
            return false;
        }  //Big O Analysis ==> O(n + n + (a * b) ==> O(2n + (a * b)) ==> O(a*b)

        public static bool CompareArrays2()
        {
            int[] firstArray = { 1, 1, 3 }; //O(n)
            int[] secondArray = { 5, 3, 6 }; //O(n)

            //Thought Process 
            //--> Loop through the First Array
            //--> then store the data in another data structure such as Dictionary
            // --> Loop through the second array 
            // --> then compare each value in the second array to value in the dictionary
            //--> returns true if they ave common values or false if they dont

            Dictionary<int, bool> map = new Dictionary<int, bool>();

            //map = {    
            //      {1, true},
            //       {2, true}
            //      }

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (!map.ContainsKey(firstArray[i])) //this validates that duplicates keys are  not copied into the dictionary 
                {
                    int item = firstArray[i];
                    //map[item] = true;
                    
                    map.Add(item, true);
                }
            }


            for (int j = 0; j < secondArray.Length; j++)
            {
                var key = map.ContainsKey(secondArray[j]);
                var val = true;
                if (key && val)
                {
                    Console.WriteLine("True");
                    return true;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("False");
            return false;

            //int[] map = { };
            //int[] item = { };
            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //    if(map[firstArray[i]] != firstArray[i])
            //    {
            //        item[i] = firstArray[i];
            //        map[item] = true;
            //    }
            //}
        }

        public static bool compareArrays3()
        {
            //Given two Arrays, Create a function that let user know (true/false)
            //whether these 2 arrays contains any common items

            //-->Thought Process
            //--> write this code in the most efficient manner based on runtime complexity
            //--> loop through the first array and copy this value into another data structure like a dictionary (key value pairs)
            //--> with the array values being saved in a key value pair data structure; looking up any data will be easy using key
            //--> then the value of each key can looked up based on the current item in the loop

            int[] firstArray = { 1, 2, 3 }; //O(n)
            int[] secondArray = { 5, 3, 6 }; //O(n)

            Dictionary<int, bool> dict = new Dictionary<int, bool>();

            foreach (var item in firstArray)
            {
                dict.Add(item, true);
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                var isContained = dict.ContainsKey(secondArray[i]);
                if (isContained)
                {
                    bool value = false;
                    var valuePair = dict.TryGetValue(secondArray[i], out value);
                    if(valuePair)
                    { Console.WriteLine("true"); return true;
                    }
                }
            }
            Console.WriteLine("false");
            return false;
        }
    }
}
