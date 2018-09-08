using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignSmells.DIExample
{
    class Paper
    {
        public string Title { get; set; }

        public Paper()
        {
        }

        public Paper(string Title)
        {
            this.Title = Title;
        }
    }
}
