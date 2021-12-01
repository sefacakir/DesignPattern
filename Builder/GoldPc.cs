using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class GoldPc : IComputer
    {
        Computer computer;
        public GoldPc()
        {
            computer = new Computer("Gold Pc");
        }
        public void CreateMonitor()
        {
            computer.Monitor = "120 Hz";
        }

        public void CreateRam()
        {
            computer.Ram = "8 GB";
        }

        public void CreateSsd()
        {
            computer.Ssd = "512 GB";
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
