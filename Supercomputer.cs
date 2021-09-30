using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Supercomputer
    {
       public string Name;
       public string Processor;
       public int Ram;
       public  int Stage;
       public int Cost;

        public Supercomputer(string name, string processor,int ram,int stage,int cost )
        {
            Name = name;
            Processor = processor;
            Ram = ram;
            Stage = stage;
            Cost = cost;
        }

        public string GetFullinfo()
        {
            return $"{Name} {Processor} {Ram} {Stage} {Cost} ";
        }
        
    }
}
