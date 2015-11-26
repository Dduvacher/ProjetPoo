using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Player
    {
        List<Pawn> Pawns { get; set; }
        string Name { get; set; }
        Race Race { get; set; }
        int Point { get; set; }
        int Order { get; set; }

        void addPawns();
    }
}