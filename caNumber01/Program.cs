using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNDL001
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    if (j%2==0 && i==1)
                    {
                        Console.Write(j + "\t");
                    }
                    else if (j%2==1 && i==0)
                    {
                        Console.Write(j + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
