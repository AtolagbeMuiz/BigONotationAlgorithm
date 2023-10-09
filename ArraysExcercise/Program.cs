using System;
using System.Linq;

namespace ArraysExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array array = new Array(3);
            //array.InsertElement(10);
            //array.InsertElement(20);
            //array.InsertElement(30);
            //array.InsertElement(40);
            //array.InsertElement(50);
            //array.insert(50);


            //array.print();

            //array.removeAtIndex(3);
            //array.print();

            //Console.WriteLine("Index of Searched Item is " + array.searchForItem(30));



            //string[] students = { "Elijah", "Bryan", "Micheal", "Matt", "Muiz" };

            ////Finding Index Of an Array Value using Buil-In Array Extension Methods.
            //Console.WriteLine(Array.IndexOf(students, "Elijah"));


            //Array.ReverseArrayItem();


            //NewArray newarray = new NewArray(3);
            //newarray.AddItemToList(2);
            //newarray.AddItemToList(5);
            //newarray.AddItemToList(6);
            //newarray.AddItemToList(9);
            //newarray.AddItemToList(8);

            //var arrayItems = newarray.GetArrayItems();
            //if(arrayItems != null )
            //{
            //    foreach (var item in arrayItems)
            //    {
            //        if (item != null)
            //        {
            //            Console.WriteLine(item);
            //        }

            //    }
            //}



            //Reverse Array
            NewArray arr = new NewArray();

            //sample array 
            dynamic[] items = {1,2,3};

            var reservedArray = arr.ReverArrayItems(items);
            foreach (var item in reservedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
