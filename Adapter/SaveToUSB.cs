﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class SaveToUSB : ISave
    {
        public void Save(string source, string savedFile)
        {
            Console.WriteLine("Files from source saved to USB.");
        }
    }
}
