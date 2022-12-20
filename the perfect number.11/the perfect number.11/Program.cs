using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_perfect_number._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter the frist number ");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("pls enter the second  number ");
            int end = int.Parse(Console.ReadLine());



            for (int a = start; a <= end; a++)
            {
                int b = 1;
                int c = 0;
                bool x = false;

                for (int i = 1; i < a; i++)
                {
                    b = a / i;
                    if (b * i == a)
                    {
                        c += i;
                    }
                    if (c == a & i == a / 2)
                    {
                        x = true;
                    }
                }
                if (x == true)
                    Console.WriteLine("{0}  ", a);

            }
        }     
    }
}
