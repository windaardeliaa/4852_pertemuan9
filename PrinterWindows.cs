using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class PrinterWindows
    {
       public virtual void Print()
        {
            Console.WriteLine("Printer Windows printing...");
        }

        public virtual void Show()
        {
            Console.WriteLine("Printer Windows display dimension : 10*11");
        }

    }

    public class Epson : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");

        }
    }

    public class Canon : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 10*11");

        }
    }

    public class LaserJet : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing....");
        }
        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension : 10*11");

        }
    }
}
