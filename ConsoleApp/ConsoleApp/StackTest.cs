using Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test
{
    static void Main()
    {
        Stack s = new Stack();
        s.push(1);
        s.push(10);
        s.push(100);
        Console.WriteLine(s.pop());
        Console.WriteLine(s.pop());
        Console.WriteLine(s.pop());
    }
}
