using System;

namespace MyPhotoshop
{
	public class LighteningFilter : PixelFilter<LighteningParameters>
	{
		
		public override string ToString ()
		{
			return "Осветление/затемнение";
		}
        
        public override Pixel ChangePixel (Pixel pixel, LighteningParameters parameters)
        {
            return pixel * parameters.Coefficient;
        }
	}
}

