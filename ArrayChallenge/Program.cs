using System;
using System.Collections.Generic;

namespace ArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = { 2, 4, 3 };
            var answer = ArrayChanllenges2(arrayNumbers);
           // Console.WriteLine(answer);
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
    }
}
