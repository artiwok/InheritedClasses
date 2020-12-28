using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InheritedClasses_2
{
    class Printer
    {
        public void Print()
        {
            Console.WriteLine("The file contains the following text:\n");

            var fileContent = new StreamReader(@"E:\scan.txt");

            Console.WriteLine(fileContent.ReadToEnd());

            Console.ReadKey();
        }

        public virtual void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
