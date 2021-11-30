using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class FormatFactory
    {
        public FormatFactory()
        {

        }
        public IFormat GetFormat(string type)
        {
            type = type.ToLower();
            if (type == "json")
                return new Json();
            else
                return new XML();
        }
    }
}
