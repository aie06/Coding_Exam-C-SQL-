using System;
using System.Collections.Generic;

namespace DuplicateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input letters: ");
                string word = Console.ReadLine();
                Console.WriteLine(DuplicateNumbers(word));
            }
           
        }
        public static string DuplicateNumbers(string letters)
        {
          
            var lets = letters.ToLower().ToCharArray();
          
            Dictionary<char, int> charMap = new Dictionary<char, int>();

            foreach (var ch in lets)
            {
                if (charMap.ContainsKey(ch))
                {
                    charMap[ch] = charMap[ch] + 1;
                }
                else
                {
                    charMap.Add(ch, 1);
                }
            }

            var keys = new HashSet<char>(charMap.Keys);

            string fword = "";
            string temp = "";
            int counter = 0;
            foreach (var ch in keys)
            {
                if (charMap[ch] > 1)
                {
                    counter++;
                    fword = counter + " characters repeat more than once";
                    temp += "'"+ch+"' " + "occurs " + charMap[ch] + " times.\n" ;               
                }
            }
            if (counter == 0)
            {
                fword = "0 # no characters repeat more than once";
            }

            return fword + "\n" +temp;
            
        }

    }
}
