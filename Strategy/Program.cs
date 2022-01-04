using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Employee(new ManagerDepartment(), new ManagerSalary());
            int salary = manager.GetSalary();
            int dayOff = manager.GetDayOff();
            Console.WriteLine("Salary: {0}\tDayOff: {1}",salary,dayOff);

            Employee engineer = new Employee(new EngineerDepartment(), new EngineerSalary());
            salary = engineer.GetSalary();
            dayOff = engineer.GetDayOff();
            Console.WriteLine("Salary: {0}\tDayOff: {1}", salary, dayOff);

        }
    }

    class Employee
    {
        IDayOff _dayOff;
        ISalary _salary;
        public Employee(IDayOff dayOff, ISalary salary)
        {
            _salary = salary;
            _dayOff = dayOff;
        }
        public int GetSalary()
        {
            return _salary.Salary();
        }
        public int GetDayOff()
        {
            return _dayOff.DayOff();
        }
    }

    interface ISalary
    {
        int Salary();
    }
    interface IDayOff
    {
        int DayOff();
    }
    class EngineerDepartment : IDayOff
    {
        public int DayOff()
        {
            return 20;
        }
    }
    class ManagerDepartment : IDayOff
    {
        public int DayOff()
        {
            return 30;
        }
    }
    class EngineerSalary : ISalary
    {
        public int Salary()
        {
            return 5000;
        }
    }
    class ManagerSalary : ISalary
    {
        public int Salary()
        {
            return 7500;
        }
    }
}
