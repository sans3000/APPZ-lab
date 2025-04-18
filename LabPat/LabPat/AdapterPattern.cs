using System;

public interface IGradeSystem
{
    string GetGrade();
}

public class LegacyGradeSystem
{
    public int GetLegacyGrade() => 95;
}

public class GradeAdapter : IGradeSystem
{
    private readonly LegacyGradeSystem _legacy;

    public GradeAdapter(LegacyGradeSystem legacy)
    {
        _legacy = legacy;
    }

    public string GetGrade() => $"Converted Grade: {_legacy.GetLegacyGrade()}";
}