using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class ModelOutput
    {
        public float[] ForecastedRentals { get; set; }

        public float[] LowerBoundRentals { get; set; }

        public float[] UpperBoundRentals { get; set; }
    }
}
