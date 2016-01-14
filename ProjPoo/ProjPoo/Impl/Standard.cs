using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelEtudiant;

namespace ProjPoo
{
    //Algorithme pour remplir la map en mode Standard
    public class Standard : FillAlgo
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

        
        public Standard(Map map)
        {
            Map = map;
            Units = 8;
            Turns = 30;
            algo = new Algo();
        }

        public int[] execute()
        {
            return algo.FillMap(map.Size);
        }
    }
}