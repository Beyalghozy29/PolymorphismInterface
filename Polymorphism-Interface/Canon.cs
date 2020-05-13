using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface
{
    class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nCanon printer dimension : 26*40");
        }

        public void Print()
        {
            Console.WriteLine("Canon printer printing...\n");
        }
    }
}