using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
   public class Class1
    {
        public int Number;

        public Class1(int number)
        {
            Number = number;
        }



        public event Action<bool> Check;

        public void Getinfo()
        {
            if (Number % 2 == 0)
            {
                Check(true);
            }
            else
            {
                Check(false);
            }
        }
            

        

    }
}
