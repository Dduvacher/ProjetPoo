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

        public PositionImpl(int x, int y)
        {
            PosX = x;
            PosY = y;
            Pawns = new List<Pawn>();
        }

        public bool putOn(Pawn p,Tiles t)
        {
            if (p.race is Elf || p.race is Orc)
            {
                if (t is Water) {return false; }
                else
                {
                    p.position = this;
                    this.Pawns.Add(p);
                    return true;
                }
            }
            else
            {
                p.position = this;
                this.Pawns.Add(p);
                return true;
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
                if (p.map.getTile(this) is Mountain) {return res= p.MovePoint >= 2;}
                else if (p.map.getTile(this) is Plain) { return res= p.MovePoint >= 1;}
                else if (p.map.getTile(this) is Forest) {return res= p.MovePoint >= 1;}
                else { return res; }
            }
            else if (p.race is Orc)
            {
                if (p.map.getTile(this) is Mountain) {return res= p.MovePoint >= 1;}
                else if (p.map.getTile(this) is Plain) { return res= p.MovePoint >= 0.5;}
                else if (p.map.getTile(this) is Forest) { return res= p.MovePoint >= 1;}
                else { return false; }
            }
            else
            {
                return res= p.MovePoint >= 1;
            }
        }
    }
}