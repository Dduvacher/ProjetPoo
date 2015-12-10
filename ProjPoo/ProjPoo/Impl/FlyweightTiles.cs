using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    //c'est une fabrique poids mouche pour les tuiles
    public class FlyweightTiles
    {

        public static FlyweightTiles INSTANCE = new FlyweightTiles();
        private Dictionary<string, Tiles> mapTiles;

        public FlyweightTiles()
        {
            mapTiles = new Dictionary<string, Tiles>();
        }

        public Tiles getForest()
        {
            Tiles t = mapTiles["forest"];

            if (t == null)
            {
                t = new ForestImpl();
                mapTiles.Add("forest", t);
            }
            return t;
        }

        public Tiles getMountain()
        {
            Tiles t = mapTiles["mountain"];

            if (t == null)
            {
                t = new MountainImpl();
                mapTiles.Add("mountain", t);
            }
            return t;
        }

        public Tiles getPlain()
        {
            Tiles t = mapTiles["plain"];

            if (t == null)
            {
                t = new PlainImpl();
                mapTiles.Add("plain", t);
            }
            return t;
        }

        public Tiles getWater()
        {
            Tiles t = mapTiles["water"];

            if (t == null)
            {
                t = new WaterImpl();
                mapTiles.Add("water", t);
            }
            return t;
        }
    }
}