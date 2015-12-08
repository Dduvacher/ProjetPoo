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
            bool res = false;
            if (p.race is Elf)
            {
                if (p.map.getTile(this) is Mountain) { res= p.MovePoint >= 2; p.MovePoint -= 2; return res; }
                else if (p.map.getTile(this) is Plain) { res= p.MovePoint >= 1; p.MovePoint -= 1; return res; }
                else if (p.map.getTile(this) is Forest) { res= p.MovePoint >= 1; p.MovePoint -= 1; return res; }
                else { return res; }
            }
            else if (p.race is Orc)
            {
                if (p.map.getTile(this) is Mountain) { res= p.MovePoint >= 1; p.MovePoint -= 1; return res; }
                else if (p.map.getTile(this) is Plain) { res= p.MovePoint >= 0.5; p.MovePoint -= 0.5; return res; }
                else if (p.map.getTile(this) is Forest) { res= p.MovePoint >= 1; p.MovePoint -= 1; return res; }
                else { return false; }
            }
            else
            {
                res= p.MovePoint >= 1; p.MovePoint -= 1; return res;
            }
        }
    }
}