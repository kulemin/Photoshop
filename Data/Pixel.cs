using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public struct Pixel
    {
        private double r;
        public double R
        {
            get { return r; }
            set { r = CheckValue(value); }
        }
        private double g;
        public double G
        {
            get { return g; }
            set { g = CheckValue(value); }
        }
        private double b;
        public double B
        {
            get { return b; }
            set { b = CheckValue(value); }
        }
        public double CheckValue (double value)
        {
            if (value >= 0 && value <= 1) return value;
            else throw new ArgumentException();
        }
        public static double Trim (double value)
        {
            if (value < 0) return 0;
            if (value > 1) return 1;
            return value;
        }
        public Pixel (double r, double g, double b)
        {
            this.r = this.g = this.b = 0;
            this.R = r;
            this.G = g;
            this.B = b;
        }
        public static Pixel operator *(Pixel pixel, double a)
        {
            return new Pixel(
                            Pixel.Trim(pixel.R * a),
                            Pixel.Trim(pixel.G * a),
                            Pixel.Trim(pixel.B * a));
        }
        public static Pixel operator *(double a, Pixel pixel)
        {
            return pixel * a;
        }
    }
}
