using System.Collections.Generic;

namespace ObjectOrientedDesignSmells.DIExample2
{
    class PaperSQLServerRepository
    {
        public List<Paper> GetPapers()
        {
            List<Paper> papers = new List<Paper>
            {
                new Paper("Paper1 from SQLServer"),
                new Paper("Paper2 from SQLServer"),
                new Paper("Paper3 from SQLServer")
            };
            return papers;
        }
    }
}
