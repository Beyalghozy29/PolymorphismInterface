﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface
{
    class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nLaserJet printer dimension : 29*03");
        }

        public void Print()
        {
            Console.WriteLine("LaserJet printer printing...\n");
        }
    }
}