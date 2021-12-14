using System;
using System.Collections.Generic;

namespace Composite
{
    class EmployeePositions : IEmployeeComponent
    {
        string _ad;
        Position _position;
        List<IEmployeeComponent> list;
        public EmployeePositions(string ad, Position position)
        {
            _ad = ad;
            _position = position;
            list = new List<IEmployeeComponent>();
        }
        public void DrawHierarchy()
        {
            foreach (var item in list)
            {
                Console.WriteLine(_position.ToString()+" "+_ad);
                item.DrawHierarchy();
            }
        }

        public void Add(IEmployeeComponent employee)
        {
            list.Add(employee);
        }
    }


}
