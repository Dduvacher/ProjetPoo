using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Position
    {
        int PosX { get; set; }
        int PosY { get; set; }

        List<Pawn> Pawns { get; set; }

        bool estVide();
        bool nextTo(Position pos);

        bool inRange(Position pos);

        bool canMove(Pawn p);

        Pawn selectDefender();

        bool putOn(Pawn p, Tiles t);
    }
}