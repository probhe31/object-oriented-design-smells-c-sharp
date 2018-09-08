using ObjectOrientedDesignSmells.DelegationExample;
using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignSmells.DelegationExample
{
    class Delegation2
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            items.Add("Granola");
            items.Add("Milk");
            items.Add("Eggs");

            Queue<string> itemsqueue = new Queue<string>();
            itemsqueue.Enqueue("Granola");
            itemsqueue.Enqueue("Milk");
            itemsqueue.Enqueue("Eggs");

            //PUEDE UTILIZARSE CUALQUIERA
            GroceyCollection collection = new GroceyCollection(itemsqueue);
            collection.toString();
        }

        public static void PrintList(ICollection<String> items)
        {
            Console.WriteLine("Grocery List");
            Console.WriteLine("------------\n");
            int index = 1;
            foreach (String item in items)
            {
                Console.WriteLine(String.Format("{0} {1}", index++, item));
            }
            Console.WriteLine("");
        }
    }
}
