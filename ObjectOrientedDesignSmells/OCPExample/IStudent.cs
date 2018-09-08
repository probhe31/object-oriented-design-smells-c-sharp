using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignSmells.OCPExample
{
    abstract class IStudent
    {
        public string Name { get; set; }

        public abstract void SaySomething();
        
        public IStudent(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return String.Format("{0} : {1}", this.GetType(), Name);
        }
    }
}
