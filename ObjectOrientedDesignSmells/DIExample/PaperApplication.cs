using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignSmells.DIExample
{
    class PaperApplication
    {
        private readonly PaperSQLServerRepository _paperSQLServerRepository = new PaperSQLServerRepository();

        public PaperApplication()
        {
        }

        public List<Paper> GetPapers()
        {
            return _paperSQLServerRepository.GetPapers();
        }
    }
}
