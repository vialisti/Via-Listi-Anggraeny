using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class Printer
    {
        private String brand;
        private String series;
        private int ppm;

        public Printer(String brand,String series, int ppm)
        {
            this.brand = brand;
            this.series = series;
            this.ppm = ppm;
        }

        public String getBrand()
        {
            return this.brand;
        }
        public String getSeries()
        {
            return this.series;
        }
        public int getPpm()
        {
            return this.ppm;
        }

        public override string ToString()
        {
            return $"printer brand: {this.brand}; printer series : {this.series}; Printer pper per minutes (ppm) : {this.ppm}";
        }
    }
}
