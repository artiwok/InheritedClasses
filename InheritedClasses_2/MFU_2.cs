using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses_2
{
    public class MFU_2
    {
        public string name;
        public string model;
        public int price;
        public Printer_2 printer;

        public MFU_2(string name, string model, int price, Printer_2 printer)
        {
            this.name = name;
            this.model = model;
            this.price = price;
            this.printer = printer;
        }

        public void PrintFromPrinter_2(string x)
        {
            printer.PrintFromConsole(model);

        }
    }
}
