using System;

namespace InheritedClasses_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner_2 scanner = new Scanner_2();
            Printer_2 printer = new Printer_2();
            string txt = scanner.ScanFromConsole();
            printer.PrintFromConsole(txt);

            HP_Scanner hp_scanner = new HP_Scanner("PIXMA G2410", 6000);
            Console.WriteLine(hp_scanner.name);
            Console.WriteLine(hp_scanner.price);

            HP_Printer hp_printer = new HP_Printer("SIGMA", 3498);
            hp_printer.PrintFromConsole("hello");

            //Printer_2 _printer = new Printer_2();

            MFU_2 multi = new MFU_2("xxx", "yyy", 1000, hp_printer);

            multi.PrintFromPrinter_2("some text");
        }
    }
}
