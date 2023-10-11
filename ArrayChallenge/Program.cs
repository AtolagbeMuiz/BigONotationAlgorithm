using System;
using System.Collections.Generic;

namespace ArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arrayNumbers = { 2, 4, 3 };
            //var answer = ArrayChanllenges2(arrayNumbers);
            // Console.WriteLine(answer);

            //MergeSortedArrays();
            //MergeSortedArrays3();


            TwoSum sum = new TwoSum();
            sum.TwoSumChallenge();

        }

        public static List<int> ArrayChallenges()
        {
            //-->For each element of an array, a counter is set to 0
            //-->The element is compared to each element to its left 
            //-->If the element to the left is greater, the absolute difference is subtracted from the counter
            //-->If the element to the left is less,  the absolute difference is added to the counter
            //-->for each element of the array, determine the value of the counter
            //--> The values should be stored in array and returned.


            //--------Thought Process-----------------------
            //--> Declare Array
            //--> Declare Counter and initilized it to zero
            //--> loop Through the given array and store values of an array so as to keep track of the initial values
            // --> Compare the initial value with the current value;
            //--> perform operation 


            int[] arrayNumbers = { 2, 4, 3 };

            int counter = 0;
            //int 

            int intialValue = 0;
            List<int> returnedValues = new List<int> ();

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (intialValue > arrayNumbers[i])
                {
                    
                    var absoluteDifference = arrayNumbers[i] - intialValue;
                    counter = absoluteDifference - counter;

                    returnedValues.Add(counter);

                    intialValue = arrayNumbers[i];

                }
                else
                {
                    if (arrayNumbers[0] == arrayNumbers[i])
                    {
                        intialValue = arrayNumbers[i];
                        returnedValues.Add(0);
                    }
                    else
                    {
                        
                        var absoluteDifference = arrayNumbers[i] - intialValue;
                        counter = counter + absoluteDifference;
                        returnedValues.Add(counter);

                        intialValue = arrayNumbers[i];
                    }
                }
                //counter++;
            }
            return returnedValues;
        }


        public static List<int> ArrayChanllenges2(int[] arrayNumbers)
        {
            List<int> arrayofCounters = new List<int> ();
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                int counter = 0;
                if (i == 0) break;

                int currentIndex = i;
                int previousIndex = i - 1;
                int current = arrayNumbers[currentIndex];
                int prev = arrayNumbers[previousIndex];

                // 2, 4, 3
                while (previousIndex >= 0)
                {
                    var tempCounter = 0;
                    if (prev > current) tempCounter -= Math.Abs(current - prev);
                    else tempCounter = tempCounter + Math.Abs(current - prev);
                    previousIndex--;
                    counter += tempCounter;
                }



                //int value = getCounter(i);
                arrayofCounters.Add(counter);
            }

           // Console.WriteLine(arrayofCounters);
            return arrayofCounters;
        }

        public static void MergeSortedArrays()
        {
            int[] array1 = {0, 3, 4 , 31};
            int[] array2 = {4, 6, 30};

            //--> take the two sorted arrays
            //--> loop through each of the these arrays and compare their values
            //--> create an instance of a new array
            ///--> the add the lowest to the new merged array
            /////-->

            //int[] mergedArray = new int[array1.Length + array2.Length] { };
            dynamic[] mergedArray =  new dynamic[array1.Length + array2.Length];

            int mergedArrayIndex = 0;
            int array1Tracker = 1;
            int array2Tracker = 1;

            int array1Item = array1[0];
            int array2Item = array2[0];

           //--> { 0, 3, 4 , 31}        { 4, 6, 30 }; --> {0, 3, 4, 4, 6, 30, 31}
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1Item < array2Item)
                {
                    mergedArray[mergedArrayIndex] = array1Item;
                    array1Item = array1[array1Tracker];

                    mergedArrayIndex++;
                    array1Tracker++;
                }
                else
                {
                    mergedArray[mergedArrayIndex] = array2Item;
                    array2Item = array2[array2Tracker];

                    mergedArrayIndex++;
                    array2Tracker++;
                }
            }
            for (int j = 0; j < array2.Length; j++)
            {
                if ( array1Item < array2Item)
                {
                    mergedArray[mergedArrayIndex] = array1Item;
                    if (array1Tracker < array1.Length)
                    {
                        array1Item = array1[array1Tracker];
                    }
                    mergedArrayIndex++;
                    array1Tracker++;
                    
                    
                }
                else
                { 
                    mergedArray[mergedArrayIndex] = array2Item;
                    if (array2Tracker < array2.Length)
                    {
                        array2Item = array2[array2Tracker];
                    }
                    mergedArrayIndex++;
                    array2Tracker++;
                       
                }

            }
        }

        public static dynamic MergeSortedArrays2()
        {
            int[] array1 = { 0, 3, 4, 31 };
            int[] array2 = { 4, 6, 30 };

            dynamic[] mergedArray = new dynamic[array1.Length + array2.Length];

            int mergedArrayIndex = 0;
            int i = 1;
            int j = 1;
            int? array1Item = array1[0];
            int? array2Item = array2[0];

            //--> { 0, 3, 4 , 31}        { 4, 6, 30 }; --> {0, 3, 4, 4, 6, 30, 31}

            do
            {
                if(!array2Item.HasValue || array1Item < array2Item)
                {
                    mergedArray[mergedArrayIndex] = array1Item;
                    array1Item = array1[i];

                    i++;
                    mergedArrayIndex++;
                }
                else
                {
                    mergedArray[mergedArrayIndex] = array2Item;
                    if (j < array2.Length)
                    {
                        array2Item = array2[j];
                        j++;
                    }
                    else { array2Item = null; }
                    
                    mergedArrayIndex++;
                }

            } while (array1Item.HasValue || array2Item.HasValue);

            return mergedArray;
        }


        public static int[] MergeSortedArrays3()
        {
            int[] arr1 = { 0, 3, 4, 31 };
            int[] arr2 = { 4, 6, 30 };

            int length1 = arr1.Length;
            int length2 = arr2.Length;

            dynamic mergedArray = new dynamic[length1 + length2];

            int i = 0, j = 0, k = 0;

            while (i < length1 && j < length2)
            {
                if (arr1[i] < arr2[j])
                {
                    mergedArray[k] = arr1[i];
                    i++;
                    k++;
                }
                else
                {
                    mergedArray[k] = arr2[j];
                    j++;
                    k++;
                }
            }

            while (i < length1)
            {
                mergedArray[k] = arr1[i];
                i++;
                k++;
            }

            while (j < length2)
            {
                mergedArray[k] = arr2[j];
                j++;
                k++;
            }

            return mergedArray;
        }

    }
}
