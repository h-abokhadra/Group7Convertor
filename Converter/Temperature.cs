using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Temperature
    {
        public double FarenheitToCelsius(double faren)
        {
            return (faren - 32) * 5.0 / 9;
        }

        public double CelsiusToFarenheit(double cel)
        {
            return (cel * 9.0 / 5) + 32;
        }
    }
}
