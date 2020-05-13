using System;

namespace Polymorphism_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinterWindows Printer;

            Console.WriteLine("Pilih Salah Satu Printer : ");
            Console.WriteLine("1. E p s o n");
            Console.WriteLine("2. C a n o n");
            Console.WriteLine("3. L a s e r J e t \n");

            Console.Write("Nomor Printer [1...3] : ");
            int NOPrinter = Convert.ToInt32(Console.ReadLine());

            if      (NOPrinter == 1)
                Printer = new Epson();
            else if (NOPrinter == 2)
                Printer = new Canon();
            else if (NOPrinter == 3)
                Printer = new LaserJet();
            else
            {
                Console.WriteLine("\nAnda Salah input\n");
                return;
            }

            
            Printer.Show();
            Printer.Print();
        }
    }
}