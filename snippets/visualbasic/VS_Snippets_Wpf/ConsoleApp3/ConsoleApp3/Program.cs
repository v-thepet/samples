using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class MyAbstractClass
    {
        static void Main(string[] args)
        {
            myNewType t = new myNewType();
            t.MyMethod(12345);
        }
    }

    public class myNewType
    {
    }
}
