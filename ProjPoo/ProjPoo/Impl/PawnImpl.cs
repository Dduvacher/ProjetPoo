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
        private Race rac;
        private Map m;
        private double mp;
        private int lp;

        public PawnImpl(Player p, Race r,Map m)
        {
            player = p;
            rac = r;
            mp = movePointMax;
            lifePoint = r.Life;
            m = m;
        }


        public Map map
        {
            get
            {
                return m;
            }

            set
            {
                m = value;
            }
        }

        public double MovePoint
        {
            get
            {
                return mp;
            }

            set
            {
                mp = value;
            }
        }

        Player Pawn.player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        Position Pawn.position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        Race Pawn.race
        {
            get
            {
                return rac;
            }

            set
            {
                rac = value;
            }
        }

        public int lifePoint
        {
            get
            {
                return lp;
            }

            set
            {
                lp = value;
            }
        }

        public double getAttack()
        {
            return rac.Attack * (lp / rac.Life);
        }

        public double getDefence()
        {
            return rac.Defence * (lp / rac.Life);
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

        public void useMovePoint(Position pos)
        {
            if (this.rac is Elf)
            {
                if (pos is Mountain) { this.MovePoint -= 2; }
                else { this.MovePoint -= 1; }
            }
            else if (this.rac is Orc)
            {
                if (pos is Plain) { this.MovePoint -= 0.5; }
                else{ this.MovePoint -= 1; }
            }
            else
            {
                this.MovePoint -= 1;
            }
        }

        public void move_action(Position pos)
        {
            if (this.position.nextTo(pos))
            {
                if (pos.estVide() || pos.Pawns[0].player==this.player)
                {
                    if (pos.canMove(this))
                    {
                        this.position.Pawns.Remove(this);
                        this.position = pos;
                        pos.Pawns.Add(this);
                        this.useMovePoint(pos);
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

            else if (this.rac is Elf)
            {
                if (this.position.inRange(pos) && !pos.estVide() && pos.Pawns[0].player != this.player)
                {
                    attack_action(pos);
                }
            }

            else if (this.rac is Orc && this.map.getTile(this.position) is Mountain)
            {
                if (this.position.inRange(pos) && !pos.estVide() && pos.Pawns[0].player != this.player)
                {
                    attack_action(pos);
                }
            }
        }


    }
}