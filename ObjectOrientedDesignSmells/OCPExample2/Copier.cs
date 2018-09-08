using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignSmells.OCPExample2
{
    class Copier
    {
        // remember to reset these flags
        public static bool scannerFlag = true;
        public static bool databaseFlag = true;

        public static void Copy()
        {
            string value;
            while ((value = (scannerFlag ? Scanner.Read() : Keyboard.Read())) != "-1")
            {
                if (databaseFlag)
                {
                    Database.Write(value);
                }
                else
                {
                    Printer.Write(value);
                }
            }
        }
    }
}
