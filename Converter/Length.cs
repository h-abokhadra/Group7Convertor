using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Length
    {
        public double FootToMeter(double foot)
        {
            return foot / 3.2808;
        }

        public double MeterToFoot(double meter)
        {
            return meter * 3.2808;
        }
    }
}
