using System;

public abstract class Report
{
    protected IReportGenerator generator;

    protected Report(IReportGenerator generator)
    {
        this.generator = generator;
    }

    public abstract void Show();
}

public interface IReportGenerator
{
    void Generate();
}

public class PDFReport : IReportGenerator
{
    public void Generate() => Console.WriteLine("PDF report generated");
}

public class GradeReportBridge : Report
{
    public GradeReportBridge(IReportGenerator generator) : base(generator) { }

    public override void Show()
    {
        Console.Write("Generating report: ");
        generator.Generate();
    }
}