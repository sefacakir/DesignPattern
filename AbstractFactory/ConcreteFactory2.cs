using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConcreteFactory2 : PcFactory
    {
        public IHdd CreateHdd()
        {
            return new HddConcrete2();
        }

        public IRam CreateRam()
        {
            return new RamConcrete2();
        }
    }
}
