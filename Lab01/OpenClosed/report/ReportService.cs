// ReportService.cs
public class ReportService
{
    private readonly ReportExporterBase exporter;

    public ReportService(ReportExporterBase exporter)
    {
        this.exporter = exporter;
    }

    public void ExportReport(string content)
    {
        exporter.Export(content);
    }
}
