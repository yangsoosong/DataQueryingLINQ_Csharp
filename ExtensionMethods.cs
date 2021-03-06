public interface IWorker {
  string Name { get; set; }
  int YearsOfExperience { get; set; }
  string Scope { get; set; }
  }

  public class Writer : IWorker {
    public string Name { get; set; }
    public int YearsOfExperience { get; set; }
    public string Scope { get; set; }
    public void Write() { /*...*/ }
  }

  public class Teacher : IWorker {
    public string Name { get; set; }
    public int YearsOfExperience { get; set; }
    public string Scope { get; set; }
    public void Teach() { /*...*/ }
  }

  public static class IWorkerExtension {
    public static void Introduce1(this IWorker worker) {
      Console.WriteLine($"Hi, my name is {worker.Name}.");
    }
    public static void Introduce1(this IWorker worker) {
      Console.WriteLine($"Hi, my name is {worker.Name}.");
    }
    public static void Introduce1(this IWorker worker) {
      Console.WriteLine($"Hi, my name is {worker.Name}.");
    }
  }
