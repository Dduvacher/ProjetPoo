using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public class Orc : Race
    {
        private Dictionary<Tiles,int> victPoint;

        public int Attack
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Defence
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Life
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Range
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

   

        Dictionary<Tiles, int> Race.VictPoint
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Orc()
        {
            Attack = 5;
            Defence = 2;
            Life = 17;
            victPoint = new Dictionary<Tiles, int>();
            victPoint.Add(FlyweightTiles.INSTANCE.getForest(), 1);
            victPoint.Add(FlyweightTiles.INSTANCE.getMountain(), 2);
            victPoint.Add(FlyweightTiles.INSTANCE.getPlain(), 1);
            victPoint.Add(FlyweightTiles.INSTANCE.getWater(), 0);
        }

    }
}