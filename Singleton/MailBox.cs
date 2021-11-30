using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class MailBox
    {
        private int _size;
        private string _backgroundColor;
        private static MailBox mailBox = new MailBox();
        private MailBox()
        {
            _backgroundColor= "black";
            _size = 10;
        }

        public static MailBox GetInstance()
        {
            return mailBox;
        }
        public void PrintInformation()
        {
            Console.WriteLine("Size: "+_size);
            Console.WriteLine("Background Color: "+_backgroundColor);
            Console.WriteLine("\n");
        }
        public void SetBox(int size, string backgroundColor)
        {
            _size = size;
            _backgroundColor = backgroundColor;
        }
    }
}
