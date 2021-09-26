using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string arr = Console.ReadLine();

            Compare(int.Parse(arr));
           
        }

        static void Compare( params int[] arr)
        {

            int eb = 0;
            
            for (int i = 0; i<100; i++)
                
            {
                if (arr[0] > eb)
                {
                    eb = arr[i];
                }

            }
            Console.WriteLine("en boyuk massiv"+"   "+eb);          
            
            
            

        }

    }
}
