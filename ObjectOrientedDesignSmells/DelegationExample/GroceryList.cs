using System;
using System.Collections;
using System.Collections.Generic;

namespace ObjectOrientedDesignSmells.DelegationExample
{

    class GroceyCollection
    {
        public ICollection collection;

        public GroceyCollection(ICollection _collection)
        {
            this.collection = _collection;
        }

        public string toString()
        {
            string result = "Grocery List\n------------\n\n";
            int index = 1;
            foreach (String item in this.collection)
            {
                result += String.Format("{0}. {1}", index++, item) + "\n";
            }
            return result;
        }
    }
}
