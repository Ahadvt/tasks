using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1den 10a qeder olan tek ededlerin hasilini tapin
            int n = 10;
            int i = 0;
            int h = 1;

            while (i < n)
            {
                i++;
                if (i % 2 != 0)
                {
                    h *= i;
                }
                
                   
            }

            Console.WriteLine(h);
        }
    }
}
