using System;

namespace Composite
{
    class Employee :IEmployeeComponent
    {
        string _ad;
        Position _position;
        public Employee(string ad, Position position)
        {
            _ad = ad;
            _position = position;
        }

        public void DrawHierarchy()
        {
            Console.WriteLine(_position.ToString()+" "+_ad);
        }
    }


}
