using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public class PawnImpl : Pawn
    {
        public const double movePointMax = 2;
        private Player player;
        private Position position;
        private Race race;

        public PawnImpl(Player p, Race r)
        {
            player = p;
            race = r;
            MovePoint = movePointMax;
        }

        public Map map
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

        public double MovePoint
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

        Player Pawn.player
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

        Position Pawn.position
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

        Race Pawn.race
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

        public void attack_action()
        {
            throw new NotImplementedException();
        }

        public void move_action(Position pos)
        {
            if (this.position.nextTo(pos))
            {
                if (pos.estVide())
                {
                    if (pos.canMove(this))
                    {
                        this.position = pos;
                        pos.Pawns.Add(this);
                    }
                }
                else
                {
                    attack_action();
                }
            }

            else if (this.race is Elf)
            {
                if (this.position.inRange(pos))
                {
                    attack_action();
                }
            }

            else if (this.race is Orc && this.map.getTile(this.position) is Mountain)
            {
                if (this.position.inRange(pos))
                {
                    attack_action();
                }
            }
        }
    }
}