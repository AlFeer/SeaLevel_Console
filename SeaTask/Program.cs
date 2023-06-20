using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace SeaTask
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine().ToLower();


            try
            {
                Validation(word);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }

            

            int score = Score(word);
            Console.WriteLine($"Score: '{score}'");
        }

        public static void Validation(string word)
        {

            string allowable = "ud";

            foreach (var c in word)
            {
                if (!allowable.Contains(c.ToString()))
                {
                    throw new Exception();
                }
            }
        }


        public static int Score(string word)
        {

            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]=='u')
                {
                    sum++;
                }

                if (word[i] == 'd')
                {
                    sum--;
                }
            }

           return sum;
        }
    }
}
