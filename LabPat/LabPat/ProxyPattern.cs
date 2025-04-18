using System;

public interface IGradeAccess
{
    void ShowGrade();
}

public class RealGradeAccess : IGradeAccess
{
    public void ShowGrade() => Console.WriteLine("Access granted: Showing grades.");
}

public class GradeAccessProxy : IGradeAccess
{
    private RealGradeAccess _realAccess = new RealGradeAccess();
    private string _role;

    public GradeAccessProxy(string role) => _role = role;

    public void ShowGrade()
    {
        if (_role == "Admin")
            _realAccess.ShowGrade();
        else
            Console.WriteLine("Access denied: Insufficient permissions.");
    }
}
