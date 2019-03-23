using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class GrayscaleFilter : PixelFilter<EmptyParameters>
    {
        public override string ToString()
        {
            return "Оттенки серого";
        }
       
        public override Pixel ChangePixel (Pixel pixel, EmptyParameters parameters)
        {
            var grayScale = (pixel.R + pixel.G + pixel.B) / 3;
            return new Pixel(grayScale, grayScale, grayScale);
        }
    }
}


