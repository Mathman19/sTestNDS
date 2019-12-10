using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNDL004
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] nmb = new int[input];
            int a = 100;
            for (int i = 0; i < input; i++)
            {
                while (a>nmb[i] && i<input)
                {
                    if (one(a,a)==true)
                    {
                        //output(a);
                        nmb[i] = a;
                        a++;
                        break;
                    }
                    else
                    {
                        a++;
                    }
                }
            }
        }
        protected static bool one(int number, int number1)
        {
            char[] arr = number.ToString().ToCharArray();
            int[] arrNmb = new int[arr.Length];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arrNmb[i] = (int)char.GetNumericValue(arr[i]);
                sum = sum + (arrNmb[i] * arrNmb[i]);
            }
            if (sum == 1)
            {
                output(number1);
                return true;
            }
            else if (sum >= 10)
            {
                
                if (one(sum, number1)==false && sum >10)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static void output(int x)
        {
            Console.WriteLine(x + " is The One Number");
        }
    }
}
