using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses_2
{
    public class HP_Printer : Printer_2
    {
        public string name = "hp";
        public string model;
        public int price;

        public HP_Printer(string model, int price)
        {
            this.model = model;
            this.price = price;
        }

        public override void PrintFromConsole(string x)
        {
            Console.WriteLine(name);
            base.PrintFromConsole(x);
        }
    }
}
