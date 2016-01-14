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
            Tiles t;

            if (!mapTiles.ContainsKey("forest"))
            {
                t = new ForestImpl();
                mapTiles.Add("forest", t);
            }
            else
            {
                t = mapTiles["forest"];
            }
            return t;
        }

        public Tiles getMountain()
        {
            Tiles t;

            if (!mapTiles.ContainsKey("mountain"))
            {
                t = new MountainImpl();
                mapTiles.Add("mountain", t);
            }
            else
            {
                t = mapTiles["mountain"];
            }
            return t;
        }

        public Tiles getPlain()
        {
            Tiles t;

            if (!mapTiles.ContainsKey("plain"))
            {
                t = new PlainImpl();
                mapTiles.Add("plain", t);
            }
            else
            {
                t = mapTiles["plain"];
            }
            return t;
        }

        public Tiles getWater() 
        {
            Tiles t;

            if (!mapTiles.ContainsKey("water"))
            {
                t = new WaterImpl();
                mapTiles.Add("water", t);
            }
            else
            {
                t = mapTiles["water"];
            }
            return t;
        }
    }
}