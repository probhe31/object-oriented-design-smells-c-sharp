using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignSmells.DIExample2
{
    class PaperCSVRepository
    {
        public List<Paper> GetPapers()
        {
            List<Paper> papers = new List<Paper>
            {
                new Paper("Paper1 from CSV"),
                new Paper("Paper2 from CSV"),
                new Paper("Paper3 from CSV")
            };
            return papers;
        }
    }
}
