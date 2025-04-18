using System;
using System.Collections.Generic;

public interface IFlyweightGrade
{
    void Display(string student);
}

public class FlyweightGrade : IFlyweightGrade
{
    private string _grade;

    public FlyweightGrade(string grade) => _grade = grade;

    public void Display(string student)
    {
        Console.WriteLine($"Student: {student}, Grade: {_grade}");
    }
}

public class GradeFactoryFlyweight
{
    private Dictionary<string, IFlyweightGrade> _grades = new Dictionary<string, IFlyweightGrade>();

    public IFlyweightGrade GetGrade(string grade)
    {
        if (!_grades.ContainsKey(grade))
            _grades[grade] = new FlyweightGrade(grade);
        return _grades[grade];
    }
}
