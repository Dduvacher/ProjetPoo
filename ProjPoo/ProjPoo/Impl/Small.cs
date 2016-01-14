using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelEtudiant;

namespace ProjPoo
{
    //Algorithme pour remplir la map en mode Small
    public class Small : FillAlgo
    {
        private Map map;
        private int units;
        private int turns;
        private Algo alg;
        public Map Map
        {
            get
            {
                return map;
            }

            set
            {
                map = value;
            }
        }

        public int Units
        {
            get
            {
                return units;
            }
            set
            {
                units = value; ;
            }
        }

        public int Turns
        {
            get
            {
                return turns;
            }
            set
            {
                turns = value;
            }
        }

        public Algo algo
        {
            get
            {
                return alg;
            }

            set
            {
                alg = value;
            }
        }

     

        public Small(Map m)
        {
            Map = m;
            Units = 6;
            Turns = 20;
            algo = new Algo();
        }
        public int[] execute()
        {
           return algo.FillMap(map.Size);
        }
    }
}