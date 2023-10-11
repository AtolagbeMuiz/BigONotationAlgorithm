using System;

namespace StringsExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "Muiz is a good guy";

            //var reversedValue = ReverseString(value);
            var reversedValue = ReverseStringUsingBuiltInMethod(value);
            Console.WriteLine(reversedValue);
        }

        public static string ReverseString(string value)
        {
            if(value.Length < 2 || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("invalid input");
            }
            int count=0;
            dynamic[] array = new dynamic[value.Length];
            string result = "";
            for (int i = value.Length - 1; i >= 0; i--)
            {
                array[count] = value[i];
                count++;
            }

            foreach (var item in array)
            {
                result = result + item;
            }
            return result;
        }

        public static string ReverseStringUsingBuiltInMethod(string input)
        {
            char[] charArray = input.ToCharArray(); // Convert the string to a character array
            Array.Reverse(charArray); // Reverse the character array
            return new string(charArray); // Convert the reversed character array back to a string
        }
    }
}
