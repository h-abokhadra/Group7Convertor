using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Time
    {
        public double MinToHour(double minute)
        {
            return minute / 60.0;
        }

        public double HourToMin(double hour)
        {
            return hour * 60.0;
        }
    }
}
