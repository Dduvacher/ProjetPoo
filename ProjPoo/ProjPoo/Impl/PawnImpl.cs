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
            lifePoint = r.Life;
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

        public int lifePoint
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

        public double getAttack()
        {
            return race.Attack * (lifePoint / race.Life);
        }

        public double getDefence()
        {
            return race.Defence * (lifePoint / race.Life);
        }

        public void attack_action(Position pos)
        {
            Random r = new Random();
            Pawn def = pos.selectDefender();
            int currentDef = r.Next(10) + (int)def.getDefence();
            int currentAtt = r.Next(10) + (int)this.getAttack();
            if (currentAtt > currentDef)
            {
                def.lifePoint -= currentAtt - currentDef;
                if (def.lifePoint <= 0)
                {
                    def.position.Pawns.Remove(def);
                    def.player.Pawns.Remove(def);
                    if (def.position.estVide())
                    {
                        this.position.Pawns.Remove(this);
                        this.position = pos;
                        pos.Pawns.Add(this);
                    }
                }
            }
            else
            {
                this.lifePoint -= currentDef - currentAtt;
                if (this.lifePoint <= 0)
                {
                    this.position.Pawns.Remove(this);
                    this.player.Pawns.Remove(this);
                }
            }
        }

        public void move_action(Position pos)
        {
            if (this.position.nextTo(pos))
            {
                if (pos.estVide())
                {
                    if (pos.canMove(this))
                    {
                        this.position.Pawns.Remove(this);
                        this.position = pos;
                        pos.Pawns.Add(this);
                    }
                }
                else
                {
                    if (pos.canMove(this))
                    {
                        attack_action(pos);
                    }
                }
            }

            else if (this.race is Elf)
            {
                if (this.position.inRange(pos))
                {
                    attack_action(pos);
                }
            }

            else if (this.race is Orc && this.map.getTile(this.position) is Mountain)
            {
                if (this.position.inRange(pos))
                {
                    attack_action(pos);
                }
            }
        }


    }
}