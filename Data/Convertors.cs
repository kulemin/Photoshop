using System;
using System.Drawing;

namespace MyPhotoshop
{
	public static class Convertors
	{
		public static Photo Bitmap2Photo(Bitmap bmp)
		{
			var photo=new Photo(bmp.Width, bmp.Height);
            //photo.width = bmp.Width;
            //photo.height = bmp.Height;
            //photo.data=new double[bmp.Width,bmp.Height,3];
            //photo.data = new Pixel[bmp.Width, bmp.Height];
			for (int x=0;x<bmp.Width;x++)
				for (int y=0;y<bmp.Height;y++)
				{
				var pixel=bmp.GetPixel (x,y);
                    photo[x, y] = new Pixel(
                        (double)pixel.R / 255,
                        (double)pixel.G / 255,
                        (double)pixel.B / 255);

                    //photo.data[x, y] = new Pixel();
                    //photo[x, y].R = (double)pixel.R/255;
                    //            photo[x, y].G = (double)pixel.G/255;
                    //            photo[x, y].B = (double)pixel.B/255;
                    //photo.data[x,y,1]=(double)pixel.G/255;
                    //photo.data[x,y,2]=(double)pixel.B/255;
                }
			return photo;
		}

        static int ToChannel(double val)
        {
            if (val < 0 || val > 1)
                throw new Exception(string.Format("Wrong channel value {0} (the value must be between 0 and 1", val));
            return (int)(val * 255);
        }

        public static Bitmap Photo2Bitmap(Photo photo)
		{
			var bmp=new Bitmap(photo.width,photo.height);
			for (int x=0;x<bmp.Width;x++)
				for (int y=0;y<bmp.Height;y++)
					bmp.SetPixel(x,y,Color.FromArgb (
						ToChannel (photo[x,y].R),
						ToChannel (photo[x,y].G),
						ToChannel (photo[x,y].B) ));
					       		
			return bmp;
		}
	}
}

