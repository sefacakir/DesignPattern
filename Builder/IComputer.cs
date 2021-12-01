using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IComputer
    {
        void CreateSsd();
        void CreateMonitor();
        void CreateRam();
        void Show();
    }
}
