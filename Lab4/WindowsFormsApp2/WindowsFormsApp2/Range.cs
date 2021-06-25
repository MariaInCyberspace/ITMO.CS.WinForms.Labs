using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public static class Range
    {
        public static IEnumerable<double> DoubleRange(double from, double to, double step) 
        {
            if (step <= 0.0)
            {
                step = (step == 0.0) ? 1.0 : -step;
            }
            if (from <= to)
            {
                for (double i = from; i <= to; i += step) yield return i;
            }
            else
            {
                for (double i = from; i >= to; i -= step) yield return i;
            }
        }

        public static IEnumerable<double> DoubleRange(double from, double to)
        {
            return Range.DoubleRange(from, to, 0.1);
        }

    }
}
