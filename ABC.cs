using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class ABC
    {
        public int Number;
        public int Count;

        public ABC(int number)
        {
            Number = number;
        }

        public event Action<bool> Test;

        public void Gettest()
        {
            for (int i =2; i<=9; i++)
            {
                if (Number % i == 0) 
                {
                    Count++;

                    if (Count == 2)
                    {
                        Test(true);
                        break;
                    }
                }

            }
            if (Count==1)
            {
                Test(false);
            }
            

        }
    }
}
