using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOFdoor = 300;
            int widthOfdoor = 200;
            int lengthOfwardrob = 200;
            int widththOfwarrob = 100;
            int sideLeftTop = 50;

            if (lengthOFdoor > lengthOfwardrob && widthOfdoor > widththOfwarrob)
            {
                Console.WriteLine("true");
            }else if (lengthOFdoor>lengthOfwardrob&&widthOfdoor>sideLeftTop)
            {
                Console.WriteLine("true");
            }else if (lengthOFdoor > sideLeftTop && widthOfdoor > widththOfwarrob)
            {
                Console.WriteLine("true");
            }else if (lengthOFdoor > widththOfwarrob && widthOfdoor > sideLeftTop)
            {
                Console.WriteLine("true");
            }else if (lengthOFdoor > widththOfwarrob && widthOfdoor > sideLeftTop)
            {
                Console.WriteLine("true");
            }else if (lengthOFdoor > sideLeftTop && widthOfdoor > lengthOFdoor)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
