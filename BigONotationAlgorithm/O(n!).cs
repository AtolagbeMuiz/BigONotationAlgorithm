using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotationAlgorithm
{
    class O_n__
    {
        public static void FactorialTimeMethod()
        {
            string[] array = {"a","b", "c" };
            //a, 
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine(array[j]);

                    for (int k = 0; k < array.Length; k++)
                    {
                        Console.WriteLine(array[k]);
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
