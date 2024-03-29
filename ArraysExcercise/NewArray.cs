﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExcercise
{
    public class NewArray
    {
        private dynamic[] arrayItems;
        private int index;

        public NewArray()
        {
            
        }
        public NewArray(int length)
        {
            arrayItems = new dynamic[length];
        }

        public void AddItemToList(dynamic number)
        {
            //checks the length of the array to val;idate the array is not filled
            if(arrayItems.Length == index)
            {
                //creates an instance of a new array with twice the size of the initial array
                var dynamicSizeArray = new dynamic[index * 2];

                for (int i = 0; i < arrayItems.Length; i++)
                {
                    //copy each item in the initial array into the new-sized array
                    dynamicSizeArray[i] = arrayItems[i];
                }

                //copy the newsized array into the intitial array to the initial array the new size
                arrayItems = dynamicSizeArray;
            }
            arrayItems[index] = number;
            index++;
        }

        public dynamic GetArrayItems()
        {
            if(arrayItems.Length > 0)
            {
                return arrayItems;
            }
            return null;
        }

        public dynamic ReverArrayItems(dynamic array)
        {
            //--> validat the length of the array
            //--> create a new array 
            //--> loop through the given array from the last item
            //--> then assign each item to the new array
            //--> declare a count variable to keep track of the index value of the new array.

            if(array.Length > 0)
            {
                int count =0;
                var newArray = new dynamic[array.Length];

                for (int i = array.Length-1; i >= 0; i--)
                {
                    newArray[count] = array[i];
                    count++;
                }

                array = newArray;
                return array;
            }
            return null;
        }

        public dynamic delteItemAtIndex(int indexToDelete)
        {
            //--> take the index of the item to delete
            //--> validate the index with the length if the array
            //--> loop through the array from the index to the last item
            //--> copy the next item to the index into the cuurent index
            //--> decrement the length if the array so as to get rid of the last item that has been copied.

            if (index > arrayItems.Length|| index < arrayItems.Length)
            {
                throw new ArgumentOutOfRangeException("Index was outside the bounds of the array");
            }
            else
            {
                //var arrayCount = 0;
                dynamic[] newArray = new dynamic[arrayItems.Length-1];

                //this shift the items in the array from the index
                for (int i = indexToDelete; i < arrayItems.Length -1 ; i++)
                {
                    arrayItems[i] = arrayItems[i + 1];
                }

                //this copies the copied array into a new array so as to shrink the length of the new array
                for (int i = 0; i < arrayItems.Length-1; i++)
                {
                    newArray[i]= arrayItems[i];
                }
                return newArray;
            }
        }
    }
}
