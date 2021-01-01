using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses_2
{
    class MFU
    {
        public string name;
        public string model;
        public int price;
        public Printer printer;
        public Scanner scanner;

        public MFU(string name, string model, int price, Printer printer, Scanner scanner)
        {
            this.name = name;
            this.model = model;
            this.price = price;
            this.printer = printer;
            this.scanner = scanner;
        }

        public void Print(string x)
        {
            printer.Print(model);

        }

        public string Scan()
        {
            return scanner.ScanFromConsole();
        }
    }
}
