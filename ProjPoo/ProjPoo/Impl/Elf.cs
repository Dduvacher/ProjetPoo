using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public class Elf : Race
    {
        private Dictionary<Tiles,int> victPoint;

        public int Attack
        {
            get
            {
                return Attack;
            }

            set
            {
                Attack = value;
            }
        }

        public int Defence
        {
            get
            {
                return Defence;
            }

            set
            {
                Defence = value;
            }
        }

        public int Life
        {
            get
            {
                return Life;
            }

            set
            {
                Life = value;
            }
        }

        public int Range
        {
            get
            {
                return Range;
            }

            set
            {
                Range = value;
            }
        }

       

        Dictionary<Tiles, int> Race.VictPoint
        {
            get
            {
                return victPoint;
            }

            set
            {
                victPoint = value;
            }
        }

        public Elf()
        {
            Attack = 4;
            Defence = 3;
            Life = 12;
            victPoint = new Dictionary<Tiles, int>();
            victPoint.Add(FlyweightTiles.INSTANCE.getForest(), 3);
            victPoint.Add(FlyweightTiles.INSTANCE.getMountain(), 0);
            victPoint.Add(FlyweightTiles.INSTANCE.getPlain(), 1);
            victPoint.Add(FlyweightTiles.INSTANCE.getWater(), 0);
        }
    }
}