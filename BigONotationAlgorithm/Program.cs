using System;

namespace BigONotationAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] arrayStrings = {"Star Wars", "faith and Favour", "Bad Comments"};
            //BigOBreakDown(arrayStrings);


            //logAllPairOfArrays();

            //O_n__.FactorialTimeMethod();

            //logPairofStringArray();

            sumPairofNumberArray();
        }

        //Challenge 1
        public static void BigOBreakDown(string[] Inputs)
        {
            int a = 10; //O(1)
            a = a + 30; //O(1)


            for (int i = 0; i < Inputs.Length; i++)
            {
                int b = 0; //O(n)
                int c = 0; //O(n)

                b++; //O(n)
            }
        }

        //Challenge 1 Answer
        //Big O(2 + 3n)



        // What is the Big O of the below function? (Hint, you may want to go line by line)
        
        
        //Challenge 2
        public void  anotherFunChallenge(string input)
        {
            int a = 5;  //O(1)
            int b = 10; //O(1)
            int c = 50; //O(1)
            for (int i = 0; i < input.Length; i++) 
            {
                var x = i + 1; //O(n)
                var y = i + 2; //O(n)
                var z = i + 3; //O(n)

            }
            for (int j = 0; j < input.Length; j++)
            {
                var p = j * 2; //O(n)
                var q = j * 2; //O(n)
            }
            var whoAmI = "I don't know"; //O(1)
        }

        //Challenge 2 Answer
        // Big O ( 4 + 5n)


        //This prints all the pairs of values in the array
        public static void logAllPairOfArrays()
        {
            //int[] arrayNum = { 1, 2, 3, 4 };

            //char[] resultsArray = { };
            //for (int i = 0; i < arrayNum.Length; i++)
            //{
            //    var firstnum = Convert.ToString(arrayNum[i]);
            //    var secondNum = Convert.ToString(arrayNum[i+1]);
            //    resultsArray = (firstnum + secondNum).ToCharArray();
            //}
            //Console.WriteLine(resultsArray);

            //Console.WriteLine( );
            //Console.ReadLine();
            //string result = (firstnum + secondNum);
            //return resultsArray;

            string[] arrayNum = { "a", "b", "c", "d" };

            for (int i = 0; i < arrayNum.Length; i++)
            {
                for (int j = 0; j < arrayNum.Length; j++)
                {
                    var firstchar = arrayNum[i];
                    var secondchar = arrayNum[j];
                    Console.WriteLine(firstchar + secondchar);
                }
            }
            Console.ReadLine();

            //Big O (n^2)


        }

        public static void logPairofStringArray()
        {
            string[] arrayVal = { "a", "b", "c", "d", "e" };

            for (int i = 0; i < arrayVal.Length; i++)
            {
                for (int j = 0; j < arrayVal.Length; j++)
                {
                    Console.WriteLine(arrayVal[i] + arrayVal[j]);
                }
            }
        }


        public static void sumPairofNumberArray()
        {
            int[] arrayNum = { 1, 2, 3, 4 };

            foreach (int i in arrayNum)
            {
                foreach (int j in arrayNum)
                {
                    Console.WriteLine( i + j);
                }
            }
        }

    }
}
