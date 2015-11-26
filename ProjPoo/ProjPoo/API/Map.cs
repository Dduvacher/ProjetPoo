using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Map
    {
        List<Tiles> Tiles { get; set; }
        int Size { get; set; }
        FillAlgo PhilAlgo { get; set; }

        void fillMap();
        void defAlgo(int size);
    }
}