using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    public static class Methods
    {
        public static string CapitalizeEveryOtherLetter(this string sentence)
        {
            StringBuilder result = new StringBuilder(sentence.Length);

            for (int i = 0; i < sentence.Length; i++)
            {
                char currentChar = sentence[i];
                if (i % 2 == 0)
                {
                    result.Append(char.ToUpper(currentChar));
                }
                else
                {
                    result.Append(char.ToLower(currentChar));
                }
            }

            return result.ToString();
        }

        public static string CapitalizeFirstLetter(this string sentence)
        {
            return char.ToUpper(sentence[0]) + sentence[1..];
        }

         public static string RemoveVowels(this string napis)
         {
            napis = Regex.Replace(napis, "[aeiou]", "", RegexOptions.IgnoreCase);
            return napis;
         }

        public static string CountChars(this string sentence)
        {
            int index = 0;
            int letterCount = 0;
            List<string> wordLengths = new List<string>();

            while (index < sentence.Length)
            {
                // check if current char is part of a word
                while (index < sentence.Length && !char.IsWhiteSpace(sentence[index]))
                {
                    index++;
                    letterCount++;
                }

                wordLengths.Add(letterCount.ToString());
                letterCount = 0;

                // skip whitespace until next word
                while (index < sentence.Length && char.IsWhiteSpace(sentence[index]))
                {
                    index++;  
                }          
            }

            StringBuilder result = new StringBuilder();
            result.Append(sentence);
            result.Append(" - ");
            result.Append(string.Join(" ", wordLengths));

            return result.ToString();
        }
        
        public static string FindNumberOfWords(this string sentence)
        {
            int numberOfWords = 0;
            int index = 0;

            while (index < sentence.Length)
            {
                // check if current char is part of a word
                while (index < sentence.Length && !char.IsWhiteSpace(sentence[index]))
                    index++;

                numberOfWords++;

                // skip whitespace until next word
                while (index < sentence.Length && char.IsWhiteSpace(sentence[index]))
                    index++;
            }
           
            return sentence + " - " + numberOfWords;
        }

        public static string FindMostFrequentLetter(this string sentence)
        {
            char temp = sentence.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            return sentence + " - " +  temp;
        }

        public static string IsSentence(this string sentence)
        {
            if (char.IsUpper(sentence[0]) && sentence.EndsWith("."))
            {
                return sentence + " - " + true;
            }
            else
                return sentence + " - " + false;
        }


    }
}
