using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(BooLean(100, 200, 300));
        }

       static bool BooLean(params int[] arr)
        {
            bool Check = true;
            int n = 300;
            foreach (int item in arr)
            {
                if (n==item)
                {
                    return Check;
                }
            }
            return false;





        }
        
    }
}
