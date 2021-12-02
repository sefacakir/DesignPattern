using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ISave disk = new SaveToDisk();
            disk.Save("source file","saved File");

            ISave usb = new SaveToUSB();
            usb.Save("source file","saved File");

            //later adapted:
            ISave cd = new SaveToCDAdapter();
            cd.Save("source file","saved File");
        }
    }
}
