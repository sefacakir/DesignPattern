using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            MailBox mailBox = MailBox.GetInstance();
            mailBox.PrintInformation();

            MailBox mailBox1 = MailBox.GetInstance();
            mailBox.PrintInformation();

            mailBox1.SetBox(20,"white");
            mailBox.PrintInformation();
            mailBox1.PrintInformation();
        }
    }
}