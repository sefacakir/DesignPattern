using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class RamConcrete1 : IRam
    {
        public void CreateRam()
        {
            Console.WriteLine("RamConcrete1 created.");
        }

        public string GetRamType()
        {
            return "This ram RamConcrete1";   
        }
    }
}
