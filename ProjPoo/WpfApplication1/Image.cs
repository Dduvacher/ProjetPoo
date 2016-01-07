using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ProjPoo;

namespace WpfApplication1
{
    class Image
    {
        private ImageBrush mountain = null;
        private ImageBrush plain = null;
        private ImageBrush forest = null;
        private ImageBrush water = null;

        private Image()
        {
            water = new ImageBrush(new BitmapImage(new Uri(@"Image/water.png", UriKind.Relative)));
        }

        public Brush BrushTile(Tiles a)
        {
            ImageBrush brush = null;
            if (a is WaterImpl)
            {
                brush = water;
            }
            return brush;
        }
    }

    
}
