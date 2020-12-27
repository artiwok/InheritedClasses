using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses_2
{
    class Canon_Printer : Printer_2
    {
        public string name = "canon";
        public string model;
        public int price;

        public Canon_Printer(string model, int price)
        {
            this.model = model;
            this.price = price;
        }
    }
}
