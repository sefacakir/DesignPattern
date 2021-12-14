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
}
