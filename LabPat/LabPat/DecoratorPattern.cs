using System;

public interface IReport
{
    void Display();
}

public class BasicReport : IReport
{
    public void Display() => Console.WriteLine("Basic Report");
}

public class ChartReport : IReport
{
    private IReport _baseReport;

    public ChartReport(IReport baseReport) => _baseReport = baseReport;

    public void Display()
    {
        _baseReport.Display();
        Console.WriteLine("With Chart");
    }
}
