using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignSmells.OCPExample2
{
    class Printer
    {
        public static void Write(string value)
        {
            Console.WriteLine(" *Printer: " + value);
        }
    }
}
