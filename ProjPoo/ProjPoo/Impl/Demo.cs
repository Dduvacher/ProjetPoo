using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
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

        public Demo()
        {
            Units = 4;
            Turns = 5;
        }

        public void execute()
        {
            throw new NotImplementedException();
        }
    }
}