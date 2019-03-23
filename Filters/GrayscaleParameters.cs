using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    class GrayscaleParameters : IParameters
    {
        double Coefficient { get; set; }

        public ParameterInfo[] GetDescription()
        {
            return new ParameterInfo[0];
        }

        public void Parse(double[] values)
        {
        //    Coefficient = values[0];
        }
    }
}
