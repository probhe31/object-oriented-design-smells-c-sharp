using System.Collections.Generic;

namespace ObjectOrientedDesignSmells.DIExample2
{
    class PaperFakeRepository
    {
        public List<Paper> GetPapers()
        {
            List<Paper> papers = new List<Paper>
            {
                new Paper("Paper1 from Fake"),
                new Paper("Paper2 from Fake"),
                new Paper("Paper3 from Fake")
            };
            return papers;
        }
    }
}
