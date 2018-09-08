using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignSmells.DelegationExample
{
    class Delegation
    {
        static void Main(string[] args)
        {
            ICollection<String> list = new LinkedList<String>();
            list.Add("Granola");
            list.Add("Milk");
            list.Add("Eggs");
            PrintList(list);
            list.Remove("Milk");
            PrintList(list);
            Console.ReadLine();
        }

        public static void PrintList(ICollection<String> items)
        {
            Console.WriteLine("Grocery List");
            Console.WriteLine("------------\n");
            int index = 1;
            foreach (String item in items)
            {
                Console.WriteLine(String.Format("{0}. {1}", index++, item));
            }
            Console.WriteLine("");
        }
    }
}
