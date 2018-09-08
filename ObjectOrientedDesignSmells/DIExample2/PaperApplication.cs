using System.Collections.Generic;

namespace ObjectOrientedDesignSmells.DIExample2
{
    class PaperApplication
    {
        private readonly PaperMySQLRepository _paperMySQLRepository;
        private readonly PaperSQLServerRepository _paperSQLServerRepository;
        private readonly PaperCSVRepository _paperCSVRepository;
        private readonly PaperFakeRepository _paperFakeRepository;

        public PaperApplication(PaperRepositoryType paperRepositoryType)
        {
            switch (paperRepositoryType)
            {
                case PaperRepositoryType.MySQL:
                    this._paperMySQLRepository = new PaperMySQLRepository();
                    break;
                case PaperRepositoryType.SQLServer:
                    this._paperSQLServerRepository = new PaperSQLServerRepository();
                    break;
                case PaperRepositoryType.CSV:
                    this._paperCSVRepository = new PaperCSVRepository();
                    break;
                case PaperRepositoryType.Fake:
                    this._paperFakeRepository = new PaperFakeRepository();
                    break;
                default:
                    this._paperMySQLRepository = new PaperMySQLRepository();
                    break;
            }
        }

        public List<Paper> GetPapers()
        {
            if (_paperMySQLRepository != null)
            {
                return _paperMySQLRepository.GetPapers();
            }
            if (_paperSQLServerRepository != null)
            {
                return _paperSQLServerRepository.GetPapers();
            }
            if (_paperCSVRepository != null)
            {
                return _paperCSVRepository.GetPapers();
            }
            if (_paperFakeRepository != null)
            {
                return _paperFakeRepository.GetPapers();
            }
            return new List<Paper>();
        }
    }
}
