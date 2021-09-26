using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("The Largest Array"+" "+TheLargest(100, 200, 300, 500, 1000, 700));
        }

        
        static int TheLargest(params int[] arry)
        {
            int eb = 0;
            foreach (int item in arry)
            {
                if (item > eb)
                {
                    eb = item;
                }
                
            }
            return eb;
        }












    }
}
