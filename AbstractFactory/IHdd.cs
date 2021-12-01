using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface IHdd
    {
        public void CreateHdd();
        public string GetHddType();
    }
}
