using System;
using MachineGun;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            Console.WriteLine("please choice mode for startin gun 'auto' or 'manual' ");
            gun.UsingGun(Console.ReadLine());
        }
    }
}
