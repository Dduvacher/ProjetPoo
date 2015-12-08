using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public class PositionImpl : Position
    {
        public List<Pawn> Pawns
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

        public int PosX
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

        public int PosY
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

        public bool estVide()
        {
            return Pawns.Count == 0;
        }

        public bool nextTo(Position pos)
        {
            return Math.Abs(this.PosX - pos.PosX) + Math.Abs(this.PosY - pos.PosY) == 1;
        }

        public bool inRange(Position pos)
        {
            return Math.Abs(this.PosX - pos.PosX) + Math.Abs(this.PosY - pos.PosY) <= 2;
        }


        public Pawn selectDefender()
        {
            Pawn best = Pawns[0];
            for (int i = 1; i < Pawns.Count; i++)
            {
                if (Pawns[i].getDefence() > best.getDefence())
                    best = Pawns[i];
            }
            return best;
        }

        public bool canMove(Pawn p)
        {
            if (p.race is Elf)
            {
                if (p.map.getTile(this) is Mountain) { return p.MovePoint >= 2; }
                else if (p.map.getTile(this) is Plain) { return p.MovePoint >= 1; }
                else if (p.map.getTile(this) is Forest) { return p.MovePoint >= 1; }
                else { return false; }
            }
            else if (p.race is Orc)
            {
                if (p.map.getTile(this) is Mountain) { return p.MovePoint >= 1; }
                else if (p.map.getTile(this) is Plain) { return p.MovePoint >= 0.5; }
                else if (p.map.getTile(this) is Forest) { return p.MovePoint >= 1; }
                else { return false; }
            }
            else
            {
                return p.MovePoint >= 1;
            }
        }
    }
}