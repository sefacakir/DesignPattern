using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class RamConcrete2 : IRam
    {
        public void CreateRam()
        {
            Console.WriteLine("RamConcrete2 created.");
        }

        public string GetRamType()
        {
            return "This ram RamConcrete2";
        }

        
    }
}
