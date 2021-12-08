namespace Bridge
{
    public class Report
    {
        private IReportFormat ReportFormat;
        public Report(IReportFormat reportFormat)
        {
            ReportFormat = reportFormat;
        }

        public virtual void Display()
        {
            ReportFormat.Generate();
        }
    }
}
