using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulations
{
    public class ArrayManipulation
    {
        public static void  AddManipulation()
        {
            string[] letters = { "a", "b", "c", "d" };
            string[] lets = { };

            var result = letters.Append("e").ToArray();
            
            var result2 = result.Prepend("x").ToArray();

            //result2.CopyTo<string[][]>(lets);

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(result2[2]);

          //  To jump values in the Array; ; usig or loop
             string[] students = { "muiz", "paul", "micheal", "ife", "Bernice", "emma", "Mubarak", "Andrew" };

            for (int i = 0; i < 8; i += 2)
            {
                System.Console.WriteLine(students[i]);
            }

        }

    }
}
