using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface
{
    class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nEpson printer dimension : 19*11");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing...\n");
        }
    }
}