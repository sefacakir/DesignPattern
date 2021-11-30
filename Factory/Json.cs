using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Json : IFormat
    {
        public void Convert()
        {
            Console.WriteLine("Text converted to Json.");
        }
    }
}
