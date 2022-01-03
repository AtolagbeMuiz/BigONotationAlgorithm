using System;
//using System.Collections.Generic;

namespace LinkedListExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.addLast(20);
            list.addLast(30);
            list.addLast(40);

            //list.addFirst(10);
            //  list.IndexOf(40);

            //list.removeFirst(20);
            //Console.WriteLine(list.contains(40)); 

            list.removeLast();
            //Console.WriteLine(list);
        }
    }
}
