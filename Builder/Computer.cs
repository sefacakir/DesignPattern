using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Computer
    {
        public string Ram { get; set; }
        public string Ssd { get; set; }
        public string Monitor { get; set; }
        public string ComputerName { get; set; }

        public Computer(string computerType)
        {
            ComputerName = computerType;
        }
    }
}
