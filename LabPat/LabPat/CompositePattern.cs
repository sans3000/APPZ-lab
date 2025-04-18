using System.Collections.Generic;
using System;

using System;
using System.Collections.Generic;

public interface IGradeComponent
{
    void Show();
}

public class GradeLeaf : IGradeComponent
{
    private string _grade;

    public GradeLeaf(string grade) => _grade = grade;

    public void Show() => Console.WriteLine("Grade: " + _grade);
}

public class GradeGroup : IGradeComponent
{
    private List<IGradeComponent> _children = new List<IGradeComponent>();

    public void Add(IGradeComponent component) => _children.Add(component);

    public void Show()
    {
        Console.WriteLine("Grade Group:");
        foreach (var child in _children)
            child.Show();
    }
}