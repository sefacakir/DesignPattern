using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Factory
    {
        PcFactory _pcFactory;
        IHdd _hdd;
        IRam _ram;
        public Factory(PcFactory pcFactory)
        {
            _pcFactory = pcFactory;
            _hdd = pcFactory.CreateHdd();
            _ram = pcFactory.CreateRam();
        }

        public void ToConnect()
        {
            _hdd.CreateHdd();
            Console.WriteLine(_hdd.GetHddType());
            _ram.CreateRam();
            Console.WriteLine(_ram.GetRamType());
        }
    }
}
