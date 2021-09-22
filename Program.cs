using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int Month = -13;
            
            if(Month>=2 && Month <=4)
            {
                Console.WriteLine("spring");
            }else if(Month>=5 && Month <= 7)
            {
                Console.WriteLine("summer");
            }else if(Month>=8 && Month <= 10)
            {
                Console.WriteLine("autmun");
            }else if(Month==11 && Month>=0 && Month<=1)
            {
                Console.WriteLine("winter");
            }
            else
            {
                Console.WriteLine("bele bir ay veya fesil movcud deyil!!!");
            }
        }
    }
}
 