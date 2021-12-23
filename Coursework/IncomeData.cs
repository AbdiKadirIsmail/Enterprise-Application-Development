using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace Coursework
{
    class IncomeData
    {
        [LoadColumn(0)]
        public string Label;
        [LoadColumn(1)]
        public float Year;
        [LoadColumn(2)]
        public float Month;
        [LoadColumn(3)]
        public float Day;

        [LoadColumn(4)]
        public float IncomeAmount;
    }
}
