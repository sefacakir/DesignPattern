using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class HddConcrete1 : IHdd
    {
        public void CreateHdd()
        {
            Console.WriteLine("HddConcrete1 created.");
        }

        public string GetHddType()
        {
            return "This hdd HddConcrete1";
        }
    }
}
