using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor lgMonitor = new Monitor("1200x600", true, 32);
            Printer hpPrinter = new Printer("HP", "MP102", 50);

            Vga nvdiaVga = new Vga("Nvidia", 2054, 2054);
            Ram samsungRam = new Ram("DDR4", 5000, 8000);
            Processor intelprocessor = new Processor();
            intelprocessor.setCache(254);
            intelprocessor.setCore(8);
            intelprocessor.setSeries("Core i7 8th Gen");

            Computer computer = new Computer.Builder(samsungRam, nvdiaVga, intelprocessor).withMonitor(lgMonitor).withPrinter(hpPrinter).build();
            Console.WriteLine(computer.ToString());
        }
    }
}
