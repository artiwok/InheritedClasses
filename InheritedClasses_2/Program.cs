using System;

namespace InheritedClasses_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scanner = new Scanner();
            Printer printer = new Printer();
            string txt = scanner.ScanFromConsole();
            printer.Print(txt);

            HP_Scanner hp_scanner = new HP_Scanner("PIXMA G2410", 6000);
            Console.WriteLine(hp_scanner.name);
            Console.WriteLine(hp_scanner.price);

            HP_Printer hp_printer = new HP_Printer("SIGMA", 3498);
            hp_printer.Print("hello");

            //Printer _printer = new Printer();

            MFU multi = new MFU("xxx", "yyy", 1000, hp_printer, hp_scanner);

            multi.Print("some text");

            multi.Scan();

            string str = multi.Scan();

            Console.WriteLine(str);
        }
    }
}
