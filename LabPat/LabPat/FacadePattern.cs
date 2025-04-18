using System;

public class DataFetcher
{
    public void Fetch() => Console.WriteLine("Fetching data...");
}

public class Analyzer
{
    public void Analyze() => Console.WriteLine("Analyzing data...");
}

public class Reporter
{
    public void Report() => Console.WriteLine("Reporting data...");
}

public class GradeReportFacade
{
    private DataFetcher fetcher = new DataFetcher();
    private Analyzer analyzer = new Analyzer();
    private Reporter reporter = new Reporter();

    public void GenerateReport()
    {
        fetcher.Fetch();
        analyzer.Analyze();
        reporter.Report();
    }
}
