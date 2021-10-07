using System;
using System.Collections.Generic;

namespace reverse_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word");
            string input = Console.ReadLine();
            ReverseWord(input);
        }


        public static void ReverseWord(string input)
        {
            string outcome = "";
            Stack<String> reverse = new Stack<string>();
            int i = 0;
            for (i = 0; i < input.Length; i++)
            {
                reverse.Push(input.Substring(i, 1));
            }

            foreach (string letter in reverse)
            {
                outcome += letter + ",";
            }
            outcome = outcome.Remove(outcome.LastIndexOf(","));
            Console.WriteLine(outcome + ".");
        }
    }
}
