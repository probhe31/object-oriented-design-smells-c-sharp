using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignSmells.OCPExample
{
    class MaterStudent : IStudent
    {
        public MaterStudent(string name) : base(name)
        {
        }

        public override void SaySomething()
        {
            Console.WriteLine(Name + " says Thesis!!!");
        }
    }
}
