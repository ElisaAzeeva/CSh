using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filecs
{
    class Program
    {
        static void Main(string[] args)
        {
            const string FILENAME = "text.txt";
            const string FILEVERB = "verb.txt";
            string text = File.ReadAllText(FILENAME);
            string verb = File.ReadAllText(FILEVERB);
            char[] delimiterChars = { ' ', '\t' };

            string[] words = text.Split(delimiterChars);
            string[] endverb = verb.Split(delimiterChars);

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < endverb.Length; j++)
                { 
                    if(words[i].Contains(endverb[j]))
                    {
                        words[i] = "уточка";
                    }

                }
            }
            File.WriteAllText(FILENAME, String.Join(" ", words));
            Console.WriteLine();
        }
    }
  
}
