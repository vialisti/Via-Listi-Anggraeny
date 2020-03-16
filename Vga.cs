using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class Vga
    {
        private String brand;
        private int graphicsClock;
        private int memoryClock;

        public Vga(String brand, int graphicsClock, int memoryClock)
        {
            this.brand = brand;
            this.graphicsClock = graphicsClock;
            this.memoryClock = memoryClock;
        }

        public String getBrand()
        {
            return this.brand;
        }

        public int getGraphicsClock()
        {
            return this.graphicsClock;
        }

        public int getMemoryClock()
        {
            return this.memoryClock;
        }

        public override string ToString()
        {
            return $"Vga Brand: {this.brand}; Vga Clock Graphics: {this.graphicsClock}; Vga Clock Memory: {this.memoryClock}";
        }
    }
}
