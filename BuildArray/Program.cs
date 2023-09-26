using System;

namespace BuildArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyArray myarray = new MyArray();

            //// var returnedData1 = myarray.getAData(0);

            // //Console.WriteLine(returnedData1);

            // Console.WriteLine("-------------------------");

            // myarray.add("hi");
            // var returnedData2 = myarray.getAData(0);
            // Console.WriteLine(returnedData2);

            dynamic[] items = {1,2,3};
            NewArray array = new NewArray(items);

            var result = array.AddItemToArray(4);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }


        }
    }
}
