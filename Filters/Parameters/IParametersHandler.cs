﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    interface IParametersHandler<TParameters>
    {
        ParameterInfo[] GetDescription();
        TParameters CreateParameters(double[] values);
    }
}