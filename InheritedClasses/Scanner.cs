using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InheritedClasses
{
    class Scanner
    {
        public void Scan()
        {
            Console.WriteLine("Enter some text, please:\n");

            string text = Console.ReadLine();

            var file = new StreamWriter(@"E:\scan.txt");

            file.Write(text);

            file.Close();

            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
