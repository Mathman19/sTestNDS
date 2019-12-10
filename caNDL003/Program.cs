using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNDL003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int input = int.Parse(Console.ReadLine());
            int[] prm1 = new int[input];
            int j = 10;
            int crk = 0;
            for (int i = 0; i < input; i++)
            {
                while (j>prm1[i] && i<input)
                {
                    for (int k = 1; k <= j; k++)
                    {
                        if (j%k==0)
                        {
                            crk++;
                        }
                    }
                    if (crk == 2)
                    {
                        if (check(j)==true)
                        {
                            prm1[i] = j;
                            j++;
                            crk = 0;
                            break;
                        }
                        else
                        {
                            j++;
                            crk = 0;
                        }
                    }
                    else
                    {
                        j++;
                        crk = 0;
                    }
                }
            }
        }
        public static bool check(int a)
        {
            char tmp = 'a';
            char[] ck = a.ToString().ToCharArray();
            for (int i = 0; i < ck.Length - 1; i++)
            {
                if (i==0)
                {
                    tmp = ck[i];
                    ck[i] = ck[ck.Length - 1];
                    ck[ck.Length - 1] = tmp;
                }
            }
            string nm = new string(ck);
            int x = Convert.ToInt32(nm);
            int ckr = 0;
            for (int k = 1; k <= x; k++)
            {
                if (x%k==0)
                {
                    ckr++;
                }
            }
            if (ckr==2)
            {
                arr2(a,x);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void arr2(int a, int b)
        {
            Console.Write(a + " and ");
            Console.WriteLine(b + " are Match");
        }
    }
}
