using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public class Human : Race
    {
        private Dictionary<Tiles,int> victPoint;


        private int attack;
        private int defence;
        private int life;
        private int range;

        public int Attack
        {
            get
            {
                return attack;
            }

            set
            {
                attack = value;
            }
        }

        public int Defence
        {
            get
            {
                return defence;
            }

            set
            {
                defence = value;
            }
        }

        public int Life
        {
            get
            {
                return life;
            }

            set
            {
                life = value;
            }
        }

        public int Range
        {
            get
            {
                return range;
            }

            set
            {
                range = value;
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

        public Human()
        {
            attack = 6;
            defence = 3;
            life = 15;
            victPoint = new Dictionary<Tiles, int>();
            victPoint.Add(FlyweightTiles.INSTANCE.getForest(), 1);
            victPoint.Add(FlyweightTiles.INSTANCE.getMountain(), 1);
            victPoint.Add(FlyweightTiles.INSTANCE.getPlain(), 2);
            victPoint.Add(FlyweightTiles.INSTANCE.getWater(), 0);
        }
    }
}