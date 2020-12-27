using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InheritedClasses_2
{
    public class Printer_2
    {
        //public void Print()
        //{
        //    Console.WriteLine("The file contains the following text:\n");

        //    var fileContent = new StreamReader(@"E:\scan.txt");

        //    Console.WriteLine(fileContent.ReadToEnd());

        //    Console.ReadKey();
        //}

        public virtual void PrintFromConsole(string str)
        {
            Console.WriteLine(str);
        }
    }
}
