using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNDL002
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToLower().Replace(" ", "").ToCharArray();
            char[] vowel = { 'a', 'í', 'u', 'e', 'o' };
            sort(word);
            char[] vw = new char[word.Length];
            char[] cns = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < vowel.Length; j++)
                {
                    if (word[i]==vowel[j])
                    {
                        OutVowel(word[i]);
                        break;
                    }
                }
                if (word[i] != vowel[i])
                {
                    OutCons(word[i]);
                }
            }
        }

        public static char[] sort(char[] x){
            char tmpg = 'a';
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (x[i] < x[j])
                    {
                        tmpg = x[j];
                        x[j] = x[i];
                        x[i] = tmpg;
                    }
                }
            }
            return x;
        }

        public static void OutVowel(char a)
        {
            Console.WriteLine("Vowel Characters: ");
            Console.Write(a);
        }

        public static void OutCons(char b)
        {
            Console.WriteLine("Consonant Charaters: ");
            Console.Write(b);
        }
    }
}
