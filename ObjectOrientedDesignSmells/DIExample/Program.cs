using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignSmells.DIExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PaperApplication paperApp = new PaperApplication();
                List<Paper> papers = paperApp.GetPapers();

                if (papers.Count <= 0)
                    return;

                foreach (Paper paper in papers)
                {
                    Console.WriteLine(paper.Title);
                }
                Console.ReadLine();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
