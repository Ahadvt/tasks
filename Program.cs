using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> test1 = delegate (int num) 
            {
                if (num > 0)
                {
                    Console.WriteLine("number is a even");
                }
                else
                {
                    Console.WriteLine("number is e odd");
                }
            };
            test1.Invoke(10);



        }

        

        
    }
}
