using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignSmells.OCPExample2
{
    class Scanner
    {
        public static string Read()
        {
            Console.WriteLine("Scanner - Enter String:");
            return Console.ReadLine();
        }
    }
}
