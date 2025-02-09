using System;
namespace Resumes{
public class Job { 
    public string _jobTitle;
    public string _companyName;
    public int _startYear;
    public int _applicationYear;
    public void Display(){
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_applicationYear}");
    }
}
}