using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses_2
{
    class HP_Scanner : Scanner
    {
        public string name = "hp";
        public string model;
        public int price;

        public HP_Scanner(string model, int price)
        {
            this.model = model;
            this.price = price;
        }

        public override string ScanFromConsole()
        {
            return base.ScanFromConsole();
        }
    }
}
