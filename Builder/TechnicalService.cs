using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class TechnicalService
    {
        public void CreateComputer(IComputer computer)
        {
            computer.CreateMonitor();
            computer.CreateRam();
            computer.CreateSsd();
        }
    }
}
