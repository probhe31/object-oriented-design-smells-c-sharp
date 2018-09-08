using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignSmells.OCPExample2
{
    class Keyboard
    {
        public static string Read()
        {
            Console.WriteLine("Keyboard - Enter String:");
            return Console.ReadLine();
        }
    }
}
