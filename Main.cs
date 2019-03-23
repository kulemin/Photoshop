using MyPhotoshop.Filters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyPhotoshop
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var window = new MainWindow();
            window.AddFilter(new PixelFilter<LighteningParameters>(
                "Осветление/затемнение",
                (pixel, parameters) => pixel * parameters.Coefficient
                ));
            window.AddFilter(new PixelFilter<EmptyParameters>(
                "Оттенки серого",
                (pixel, parameters) =>
                {
                    var grayScale = (pixel.R + pixel.G + pixel.B) / 3;
                    return new Pixel(grayScale, grayScale, grayScale);
                }
                    ));
            window.AddFilter(new TransformFilter(
                "Отразить по горизонтали",
                size => size,
                (point, size) => new Point(size.Width - point.X - 1, point.Y)
                ));
            window.AddFilter(new TransformFilter(
               "Поворот C.C.W.",
               size => new Size(size.Height, size.Width),
               (point, size) => new Point(point.Y, point.X)
               ));


            window.AddFilter(new TransformFilter<RotationParameters>
                ("Свободное вращение", new RotateTransformer()));

            Application.Run(window);
        }
    }
}
