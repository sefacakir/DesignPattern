namespace Bridge
{
    public class EmployeePerformanceReport : Report
    {
        public EmployeePerformanceReport(IReportFormat format):base(format)
        {

        }

        public override void Display()
        {
            System.Console.WriteLine("----- Çalışan Performans Raporu -----");
            base.Display();
        }
    }
}
