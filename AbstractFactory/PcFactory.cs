using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface PcFactory
    {
        public IHdd CreateHdd();
        public IRam CreateRam();
    }
}
