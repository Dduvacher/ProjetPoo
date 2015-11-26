using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface FillAlgo
    {
        int Units { get; set; }

        int Turns { get; set; }

        Map Map { get; set; }

        void execute();
    }
}