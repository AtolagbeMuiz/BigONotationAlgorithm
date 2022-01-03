using System;

namespace BuildArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myarray = new MyArray();

           // var returnedData1 = myarray.getAData(0);

            //Console.WriteLine(returnedData1);

            Console.WriteLine("-------------------------");

            myarray.add("hi");
            var returnedData2 = myarray.getAData(0);
            Console.WriteLine(returnedData2);

        }
    }
}
