using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WorkerTest
{
    static void Main(string[] args)
    {
        IWorker writer = new Writer
        {
            Name = "Timothy",
            Scope = ".NET Core",
            YearsOfExperience = 15
        };

        writer.Introduce1();
        writer.Introduce2();
        writer.Introduce3();
    }
}
