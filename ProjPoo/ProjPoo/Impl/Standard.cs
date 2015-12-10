using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelEtudiant;

namespace ProjPoo
{
    public class Standard : FillAlgo
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
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Turns
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

        public Standard()
        {
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