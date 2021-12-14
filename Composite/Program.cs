using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePositions generalManager = new EmployeePositions("Ahmet Yılmaz",Position.GeneralManager);
            EmployeePositions manager = new EmployeePositions("Mehmet Men", Position.Manager);

            EmployeePositions developer = new EmployeePositions("Yusuf Çetin", Position.Developer);
            Employee employee = new Employee("Said Erdem",Position.Assistant);

            developer.Add(employee);
            manager.Add(developer);
            generalManager.Add(manager);

            generalManager.DrawHierarchy();
        }
    }

    enum Position
    {
        GeneralManager = 1,
        Manager = 2,
        Developer = 3,
        Assistant = 4
    }

    interface IEmployeeComponent
    {
        public void DrawHierarchy();
    }

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

    class Employee:IEmployeeComponent
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
