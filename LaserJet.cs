using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorpishim_Printer
{
    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine(" Epson display dimension : 10*11 ");

        }
        public override void Print()
        {
            Console.WriteLine(" Epson Printer Printing.....");
        }
    }
}
