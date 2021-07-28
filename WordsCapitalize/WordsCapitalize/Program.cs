using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCapitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            CapitalizeYourWord();
            Console.ReadLine();
        }

        static void CapitalizeYourWord()
        {
            Console.WriteLine("Enter the Sentence that you want to capitalize words for:");
            string sentence = Console.ReadLine();
            try
            {
                string[] words = sentence.Split(' ');
                List<string> Ignore = new List<string>() { "and", "or", "but", "nor", "yet", "so", "for", "a", "an", "the", "in", "to", "of", "at", "by", "up", "for", "off", "on" };
                string result = null;
                for (int i = 0; i < words.Length; i++)
                {
                    if (Ignore.Contains(words[i]))
                    {
                        result += words[i] + " ";

                    }
                    else
                    {
                        result += words[i][0].ToString().ToUpper() + words[i].Substring(1, words[i].Length - 1) + " ";
                    }

                }
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured while entering data:{e.Message}");
            }

        }
    }
}

