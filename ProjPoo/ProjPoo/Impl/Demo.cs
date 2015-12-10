using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelEtudiant;

namespace ProjPoo
{
    //Algorithme pour remplir la map en mode Démo
    public class Demo : FillAlgo
    {
        
        private Map map;
        public Map Map
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

        public int Units
        {
            get; set;
        }

        public int Turns
        {
            get; set;
        }

        public Algo algo
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

        public Demo()
        {
            Units = 4;
            Turns = 5;
            algo = new Algo();
        }

        public int[] execute()
        {
            return algo.FillMap(map.Size);
        }
    }
}