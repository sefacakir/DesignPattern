namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new EmployeePerformanceReport(new DesktopFormat());
            report.Display();

            Report report1 = new SalesReport(new WebFormat());
            report1.Display();
        }
    }
}
