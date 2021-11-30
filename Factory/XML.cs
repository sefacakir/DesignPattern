using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class XML : IFormat
    {
        public void Convert()
        {
            Console.WriteLine("Text converted to XML.");
        }
    }
}
