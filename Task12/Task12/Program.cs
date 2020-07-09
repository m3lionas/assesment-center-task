using System;

namespace Task12
{
    class Program
    {
        public static string RemoveAdjacentLetters(string input)
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
                if (!previous.Equals(c))
                {
                    chars[n++] = c;
                    previous = c;
                }
            }

            return new string(chars).Substring(0, n);
        }

        public static string ReplacePi(string input)
        {
            return input.Replace("pi", "3.14");
        }

        public static string RemoveAndReplace(string input)
        {
            return ReplacePi(RemoveAdjacentLetters(input));
        }
        static void Main(string[] args)
        {
            string s1 = "Hello all piiii people";
            Console.WriteLine(RemoveAdjacentLetters(s1));
            Console.WriteLine(RemoveAndReplace(s1));
        }
    }
}
