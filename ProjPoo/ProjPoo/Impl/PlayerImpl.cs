using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public class PlayerImpl : Player
    {
        private List<Pawn> pawns;
        private Race race;
        private int point;
        private int order;
        private bool turn;
        private string pseudo;

        public PlayerImpl(string pseudo,Race r)
        {
            Pseudo = pseudo;
            race = r;
            isTurn = false;
            pawns = new List<Pawn>();
        }

        public List<Pawn> Pawns
        {
            get
            {
                return pawns;
            }

            set
            {
                pawns = value;
            }
        }
        

        public Race Race
        {
            get
            {
                return race;
            }

            set
            {
                race = value;
            }
        }

        public int Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }

        public int Order
        {
            get
            {
                return order;
            }

            set
            {
                Order = value;
            }
        }

        public bool isTurn
        {
            get
            {
                return turn;
            }

            set
            {
                turn = value;
            }
        }

        public string Pseudo
        {
            get
            {
                return pseudo;
            }

            set
            {
                pseudo = value;
            }
        }
        

        public void addPawns(int size,Race r,Map m)
        {
            switch(size)
            {
                case 0:
                    for (int i = 0; i < 4; i++)
                        pawns.Add(FactoryPawn.INSTANCE.createPawn(this,r,m));
                    break;

                case 1:
                    for (int i = 0; i < 6; i++)
                        pawns.Add(FactoryPawn.INSTANCE.createPawn(this, r,m));
                    break;

                case 2:
                    for (int i = 0; i < 8; i++)
                        pawns.Add(FactoryPawn.INSTANCE.createPawn(this, r,m));
                    break;
            }
        }
    }
}