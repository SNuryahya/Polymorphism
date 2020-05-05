using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorpishim_Printer
{
    public class PrinterWindows
    {
        public String merk { get; set; }

        public virtual void Show()
        {
            Console.WriteLine(" MERK display dimension : UKURAN");
        }
        public virtual void Print()
        {
            Console.WriteLine("MERK Printer Printing ....");
        }
    }
}
