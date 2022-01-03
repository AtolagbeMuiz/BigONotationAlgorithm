using System;
using System.Linq;

namespace ArraysExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(3);
            array.InsertElement(10);
            array.InsertElement(20);
            array.InsertElement(30);
            array.InsertElement(40);
            array.InsertElement(50);
            //array.insert(50);


            //array.print();

            array.removeAtIndex(3);
            //array.print();

            //Console.WriteLine("Index of Searched Item is " + array.searchForItem(30));



            //string[] students = { "Elijah", "Bryan", "Micheal", "Matt", "Muiz" };

            ////Finding Index Of an Array Value using Buil-In Array Extension Methods.
            //Console.WriteLine(Array.IndexOf(students, "Elijah"));


            //Array.ReverseArrayItem();
        }
    }
}
