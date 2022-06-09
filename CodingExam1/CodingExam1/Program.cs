using System;

namespace CodingExam1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input a string: ");
                string word = Console.ReadLine().ToLower();

                Console.Write("OUTPUT: " + toWeirdCase(word));
            }
           
        }

        public static string toWeirdCase(string word)
        {
            string final_word = "";
            string initial_word = "";
            string word_temp = "";
            string[] words_container = word.Split(" ");

            for (int i = 0; i< words_container.Length; i++)
            {
                word_temp = words_container[i];
                initial_word = "";
                for (int y=0; y< words_container[i].Length; y++)
                {
                    if (y % 2 == 0)
                    {
                       initial_word += char.ToUpper(word_temp[y]);
                    }
                    else
                    {
                        initial_word += word_temp[y];
                    }
                }
                final_word += initial_word +" ";              
            }
            return final_word;
        }
    }
}
