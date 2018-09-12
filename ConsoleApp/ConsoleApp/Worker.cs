using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class IWorkerExtension
{
    public static void Introduce1(this IWorker worker)
    {
        Console.WriteLine($"Hi, my name is {worker.Name}.");
    }
    public static void Introduce2(this IWorker worker)
    {
        Console.WriteLine($"My major scope is {worker.Scope}.");
    }
    public static void Introduce3(this IWorker worker)
    {
        Console.WriteLine($"I have {worker.YearsOfExperience} years experience.");
    }
}
public interface IWorker
{
    string Name { get; set; }
    int YearsOfExperience { get; set; }
    string Scope { get; set; }
}

public class Writer : IWorker
{
    public string Name { get; set; }
    public int YearsOfExperience { get; set; }
    public string Scope { get; set; }
}

public class Teacher : IWorker
{
    public string Name { get; set; }
    public int YearsOfExperience { get; set; }
    public string Scope { get; set; }

    /*
    Teacher(string Name, string YearsofExperience, string Scope)
    {
        this.Name = Name;
        this.YearsOfExperience = YearsOfExperience;
        this.Scope = Scope;
    }
    */
}
