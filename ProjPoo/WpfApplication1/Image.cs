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

        private ImageBrush orc = null;
        private ImageBrush human = null;
        private ImageBrush elf = null;

        private ImageBrush attack = null;
        private ImageBrush move = null;

        private ImageBrush border1 = null;
        private ImageBrush bordermove = null;

        public static Image INSTANCE = new Image();

        private Image()
        {
            water = new ImageBrush(new BitmapImage(new Uri(@"Image/water.png", UriKind.Relative)));
            plain = new ImageBrush(new BitmapImage(new Uri(@"Image/plain.png", UriKind.Relative)));
            forest = new ImageBrush(new BitmapImage(new Uri("@Image/forest.png", UriKind.Relative)));
            mountain = new ImageBrush(new BitmapImage(new Uri("@Image/mountain.png", UriKind.Relative)));

            human = new ImageBrush(new BitmapImage(new Uri(@"Image/human.png", UriKind.Relative)));
            orc = new ImageBrush(new BitmapImage(new Uri(@"Image/orc.png", UriKind.Relative)));
            elf = new ImageBrush(new BitmapImage(new Uri(@"Image/elf.png", UriKind.Relative)));

            move = new ImageBrush(new BitmapImage(new Uri(@"Image/move.png", UriKind.Relative)));
            attack = new ImageBrush(new BitmapImage(new Uri(@"Image/attack.png", UriKind.Relative)));

        }

        public Brush brushTile(Tiles a)
        {
            ImageBrush brush = null;
            if (a is WaterImpl)
            {
                brush = water;
            }else if (a is PlainImpl)
            {
                brush = plain;
            }else if (a is MountainImpl)
            {
                brush = mountain;
            }else if (a is ForestImpl)
            {
                brush = forest;
            }
            return brush;
        }


        public Brush brushRace(Tiles a)
        {
            ImageBrush brush = null;
            if (a is Orc)
            {
                brush = orc;
            }
            else if (a is Elf)
            {
                brush = elf;
            }
            else if (a is Human)
            {
                brush = human;
            }
           
            return brush;
        }

        public Brush brushAttack()
        {
            return attack;
        }

        public Brush brushMove()
        {
            return move;
        }

        

    }


}
