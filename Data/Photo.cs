using System;
using System.Drawing;

namespace MyPhotoshop
{
    public class Photo
    {
        public readonly int width;
        public readonly int height;
        private readonly Pixel[,] data;
        public Photo(int width, int height)
        {
            data = new Pixel[width, height];
            this.width = width;
            this.height = height;
            //for (int i = 0; i < width; i++)
            //    for (int j = 0; j < height; j++)
            //        data[i, j] = new Pixel();
        }
        public Pixel this[int X, int Y]
        {
            get
            {
                return data[X, Y];
            }
            set
            {
                if (X < 0 || X > width - 1 || Y < 0 || Y > height - 1) throw new IndexOutOfRangeException();
                data[X, Y] = value;
            }
        }
        //public double[,,] data;
    }
}

