using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExcercise
{
    public class Array
    {
        private int[] items;
        private int count; //used to monitor the number of elements in the array
        public Array(int length)
        {
            items = new int[length];
        }


        public void InsertElement(int number)
        {
            //insert element into the array
            //make the array dynamic in size

            if (items.Length == count)
            {
                int[] newItems = new int[count * 2]; //O(1)

                for (int i = 0; i < items.Length; i++) //O(n)
                {
                    newItems[i] = items[i];
                }
                items = newItems; //O(1)
            }
            items[count] = number; //O(1)
            count++; //O(1)
        } //Runtime Complexity = O(3 + n) ==> O(n)

        public void removeAtIndex(int indexToRemove)
        {
            //Validate the Index
            //shift all items to the left to fill the hole
            //shrink the size of the array
            if (indexToRemove >= count || indexToRemove < 0)
            {
                Console.WriteLine("Cannot Print Value: Invalid Index");
            }
            else
            {
                for (int i = indexToRemove; i < count-1; i++)
                {
                    items[i] = items[i + 1];
                }
                //var len = items.Length-1;
                count--;
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(items[i]);
                }
            }
        }


        /// <summary>
        ///  Runtime Complexity is O(n)
        //The Best Case of the Loop is if the Item is the first eemnet in the array
        //The Worst case is if it is the last item in the array then we nee to loop through the whole array
        //In Big O, we consider the worst case Senario, which is dependent on the number of items we are going to make comparisons with
        /// </summary>
        /// <param name="itemSearchedfor"></param>
        /// <returns></returns>
        public int searchForItem(int itemSearchedfor)
        {
            //Pass the Item we are searching for into the method
            //after finding the Item; 
            //Return the index of the Item

            for (int i = 0; i < count; i++)
            {
                //Console.WriteLine("STARTED lOOP");
                if (items[i] == itemSearchedfor)
                {
                    Console.WriteLine("fOUND ITEM!!!");
                    return i;
                    //break;
                }

                Console.WriteLine("Still Looping");
            }
            return -1;


        }


        public void insert(int item)
        {
            //If the Array is full, Resize it
            if (count == items.Length)
            {
                //creates a new array twice the size of the initial
                int[] newItems = new int[count * 2];

                //copy all the existing items into the new array
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }

                items = newItems;
            }
            items[count] = item;
            count++;
        }

        public void removeAt(int indexToRemove)
        {
            if (indexToRemove >= items.Length || indexToRemove < 0)
            {
                Console.WriteLine("Cannot Print Value: Invalid Index");
            }
            else
            {


                // items.Where((source, index) => index != indexToRemove).ToArray();
            }


            //foreach (object value in items)
            //{
            //    Console.WriteLine(value);
            //    //Console.WriteLine(item);
            //}
        }

        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public static void ReverseArrayItem()
        {
            int count = 0;
            int[] Arrayitems = { 1, 2, 3 };
            int[] reverserdArray = new int [Arrayitems.Length];
            //size 3 -->
            for (int i = Arrayitems.Length-1; i >= 0; i--)
            {  
                reverserdArray[count] = Arrayitems[i];
                count++;
            }
        }
    }
}
