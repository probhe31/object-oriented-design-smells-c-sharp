using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignSmells.DIExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PaperApplication paperApplication = new PaperApplication(PaperRepositoryType.SQLServer);
                List<Paper> papers = paperApplication.GetPapers();
                if (papers.Count > 0)
                {
                    foreach (Paper paper in papers)
                    {
                        Console.WriteLine(paper.Title);
                    }
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
