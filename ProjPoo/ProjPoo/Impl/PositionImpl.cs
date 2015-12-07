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
            throw new NotImplementedException();
        }

    public bool inRange(Position pos)
        {
            throw new NotImplementedException();
        }


    public bool canMove(Pawn p)
        {
            if(p.race is Elf)
            {
                if(p.map.getTile(this) is Mountain) { }
                else if (p.map.getTile(this) is Plain) { }
                else if (p.map.getTile(this) is Forest) { }
                else { }
            }
            else if(p.race is Orc)
            {
                if (p.map.getTile(this) is Mountain) { }
                else if (p.map.getTile(this) is Plain) { }
                else if (p.map.getTile(this) is Forest) { }
                else { }
            }
            else
            {
                if (p.map.getTile(this) is Mountain) { }
                else if (p.map.getTile(this) is Plain) { }
                else if (p.map.getTile(this) is Forest) { }
                else { }
            }
        }
    }
}