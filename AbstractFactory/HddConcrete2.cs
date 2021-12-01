using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class HddConcrete2 : IHdd
    {
        public void CreateHdd()
        {
            Console.WriteLine("HddConcrete2 created.");
        }

        public string GetHddType()
        {
            return "This hdd Concrete2";
        }
    }
}
