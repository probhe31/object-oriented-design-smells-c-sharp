using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignSmells.OCPExample
{
    class PhDStudent : IStudent
    {
        public PhDStudent(string name) : base(name)
        {
        }

        public override void SaySomething()
        {
            Console.WriteLine(Name + " says Hard Research!");
        }
    }
}
