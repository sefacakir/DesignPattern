using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface IRam
    {
        public string GetRamType();
        public void CreateRam();
    }
}
