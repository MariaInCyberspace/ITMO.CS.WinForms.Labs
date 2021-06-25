using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Interval
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public override string ToString()
        {
            return "Левая граница: " + FirstNumber + " , правая граница: " + SecondNumber;
        }

        public decimal SineIntervalCalc(decimal a, decimal b)
        {
            return 0;
        }
    }
}
