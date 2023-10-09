using System;

namespace ArrayRotationAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] items = { 1, 2, 3, 4, 5 };
            //int[] items = { 7, 6, 3, 8, 9 };

            //var rotatedArray = RotateArray(items);

            //for (int i = 0; i < rotatedArray.Length; i++)
            //{
            //    Console.WriteLine(rotatedArray[i]);
            //}


            //Reverse Array nth times 
            //sample --> { 1, 2, 3, 4, 5 } ==> {5, 1, 2, 3, 4} ==> {4, 5, 1, 2, 3}
            int[] items = { 1, 2, 3, 4, 5 };
            var res = RotateArrayNthTimes2(items, 2);
        }


        //sample
        //[3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
        //[6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
        //[7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]

        //-->  take the given array
        //--> get the last item from the given array and assign it as the first item in new array.
        // --> declare a count variable to keep track of the item count in the new array
        //-->  loop through the given array, and coppy it into the new array from the second index

        /// <summary>
        /// Rotates Array once
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static dynamic RotateArray(dynamic array)
        {
            if(array.Length > 0)
            {
                int count = 1;
                var newFirstItem = array[array.Length - 1];

                dynamic[] newArr = new dynamic[array.Length];
                newArr[0] = newFirstItem;

                for (int i = 0; i < array.Length-1; i++)
                {
                    newArr[count] = array[i];
                    count++;
                }
                return newArr;
            }
            return null;
        }


        public static dynamic RotateArrayNthTimes(dynamic A, int n)
        {
            if (A.Length > 1)
            {
                for (int j = 0; j < n; j++)
                {
                    // sample {1, 2 , 3, 4 } ==> cuurentValue = 1, nextValue = 2 
                    var currentValue = A[0];
                    var nextValue = A[1];
                    for (int i = 0; i < A.Length - 1; i++)
                    {
                        var res1 = nextValue = A[i + 1];
                        var res = A[i + 1] = currentValue;
                        currentValue = nextValue;
                        //currentValue++;
                    }
                    var res3 = A[0] = nextValue;
                }
            }
            return A;
        }


        public static dynamic RotateArrayNthTimes2(dynamic array, int n)
        {
            //--> loop through array and shift array item to the next index
            //--> only end the loop on the second to the last item
            //keep track of the next item as it will be useful to copy the last item into the first index

            //checks if the length of the array is greater than 1; array on one item canoot be rotated
            if (array.Length > 1)
            {

                for (int i = 0; i < n; i++)
                {
                    //will always create new instance of newArray for every rotation
                    var newArray = new dynamic[array.Length];

                    var nextValue = 0;

                    for (int j = 0; j < array.Length-1; j++)
                    {
                        //keeps track of the next value of the array; this is to know the last item in the array which will be copied to the first index
                        nextValue = array[j + 1];
                        
                        //copy the current index value to the new array
                        newArray[j + 1] = array[j];
                    }
                    //copies the last value inthe array into first index
                    newArray[0] = nextValue;

                    //copies the new array back into the original, so it can be used for the next rotation
                    array= newArray;
                }
                return array;
            }
            return null;

        }
    }
}
