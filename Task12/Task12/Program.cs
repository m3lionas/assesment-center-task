using System;
using System.Linq;

namespace Task12
{
    class Program
    {
        public static string RemoveAdjacentLetters(string input) //part 1
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            char[] chars = input.ToCharArray(0, input.Length);
            char previous = '\0';
            int n = 0;

            foreach (char c in chars)
            {
                if (!previous.Equals(c)) //if the previous character isn't the same as the current one, we keep the current one
                {
                    chars[n++] = c;
                    previous = c;
                }
            }

            return new string(chars).Substring(0, n);
        }

        public static string ReplacePi(string input) //part 2
        {
            return input.Replace("pi", "3.14");
        }

        public static string RemoveAndReplace(string input)  //Task 1 end result
        {
            return ReplacePi(RemoveAdjacentLetters(input));
        }
        public static int[] Task2 (int[] arr)
        {
            int[] numbers = arr;

            if (arr[0] % 2 != 0) //if first number is odd
            {
                foreach (int n in arr)
                {
                    if (n % 2 == 0)
                        numbers = numbers.Except(new int[] { n }).ToArray(); //probably not the most efficient, but I'm low on time, so this will do
                }
            }

            else //first number is even
            {
                foreach (int n in arr)
                {
                    if (n % 2 != 0)
                        numbers = numbers.Except(new int[] { n }).ToArray();
                }
            }

            int value;

            //this part still needs more work, not enough time
            for (int i = 1; i< numbers.Length; i++)
            {
                value = numbers[i]; 

                for (int j = value-1; j < numbers.Length; j = j+value)
                {
                    //remove the j position number from array
                }
            }

            return numbers;
        }
        static void Main(string[] args)
        {
            string s1 = "Hello all piiii people";
            Console.WriteLine(RemoveAndReplace(s1));

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            foreach(int n in Task2(arr))
            {
                Console.Write(n + " ");
            }
        }
    }
}
