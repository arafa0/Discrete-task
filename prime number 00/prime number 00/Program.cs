using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_00
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("pls Entert the frist number ");
            int start = int .Parse(Console.ReadLine());

            Console.WriteLine("pls Entert the frist number ");
            int  end  = int.Parse(Console.ReadLine());

            int i, j;
            Console.WriteLine("prime no between  start to end  ");
            for (i = start ; i <= end ; i++)
            {
                int v = 0;
                for (j = 1; j <= i; j++)
                {

                    if (i % j == 0)
                    { v = v + 1; }
                }

                if (v <= 2)
                { Console.WriteLine(i); }


            }
            Console.ReadKey();
        }
    }
}
