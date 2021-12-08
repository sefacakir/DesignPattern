namespace Bridge
{
    public class SalesReport : Report
    {
        public SalesReport(IReportFormat format):base(format)
        {

        }

        public override void Display()
        {
            System.Console.WriteLine("----- Satış Raporu -----");
            base.Display();
        }
    }
}
