using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            ABC abc = new ABC(7);


            abc.Test += delegate (bool m)
              {
                  if (m)
                  {
                      Console.WriteLine("murekkeb ededir");
                  }
                  else
                  {
                      Console.WriteLine("sade ededdir");
                  }

              };
            abc.Gettest();
            
        }
    }
}
