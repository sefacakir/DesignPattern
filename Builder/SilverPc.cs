using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class SilverPc:IComputer
    {
        Computer computer;
        public SilverPc()
        {
            computer = new Computer("Silver Pc");
        }

        public void CreateMonitor()
        {
            computer.Monitor = "60 Hz";
        }

        public void CreateRam()
        {
            computer.Ram = "4 GB";
        }

        public void CreateSsd()
        {
            computer.Ssd = "256 GB";
        }

        public void Show()
        {
            Console.WriteLine("Computer Name: " + computer.ComputerName);
            Console.WriteLine("Monitor: " + computer.Monitor);
            Console.WriteLine("SSD: " + computer.Ssd);
            Console.WriteLine("Ram: " + computer.Ram);
        }
    }
}
