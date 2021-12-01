using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(new ConcreteFactory1());
            factory.ToConnect();

            factory = new Factory(new ConcreteFactory2());
            factory.ToConnect();
        }
    }
}
