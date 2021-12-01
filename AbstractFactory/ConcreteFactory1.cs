using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{

    class ConcreteFactory1 : PcFactory
    {
        public IHdd CreateHdd()
        {
            return new HddConcrete1();
        }

        public IRam CreateRam()
        {
            return new RamConcrete1();
        }
    }
}
