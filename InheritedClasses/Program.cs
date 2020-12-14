using System;

namespace InheritedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            MFU multifunction = new MFU();

            multifunction.Scan();

            multifunction.Print();
        }
    }
}
