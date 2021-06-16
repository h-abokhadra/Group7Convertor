using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Weight
    {
        public double PoundToKilo(double pound)
        {
            return pound / 2.2046;
        }

        public double KiloToPound(double kilo)
        {
            return kilo * 2.2046;
        }
    }
}
