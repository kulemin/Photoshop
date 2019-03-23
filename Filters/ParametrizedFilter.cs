using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public abstract class ParametrizedFilter<TParameters> : IFilter
        where TParameters : IParameters, new()
    {
       
      public ParameterInfo[] GetParameters()
        {
            return new TParameters().GetDescription();
        }
        
        public Photo Process(Photo photo, double[] values)
        {
            var parameters = new TParameters();
            parameters.Parse(values);
            return Process(photo, parameters);
        }
        public abstract Photo Process(Photo photo, TParameters values);
    }
}
