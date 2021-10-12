using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1(11);

            class1.Check += delegate (bool TF)
              {
                  if (TF)
                  {
                      Console.WriteLine("cut ededdir");
                  }
                  else
                  {
                      Console.WriteLine("tek ededdir");
                  }
  
              };
            class1.Getinfo();

        }
    }
}
