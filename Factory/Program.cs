using System;

namespace Factory
{
    //Converting a typed text to formats such as json, xml
    class Program
    {
        static void Main(string[] args)
        {
            FormatFactory factory = new FormatFactory();
            IFormat format= factory.GetFormat("xml");
            format.Convert();
        }
    }
}
