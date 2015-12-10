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

        public PlayerImpl(string LName, string FName,Race r)
        {
            LastName = LName;
            FirstName = FName;
            race = r;
            isTurn = false;
        }

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

        public string Name
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

        public Race Race
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

        public int Point
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

        public int Order
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

        public bool isTurn
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

        public string LastName
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

        public string FirstName
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

        public void addPawns(int size,Race r,Map m)
        {
            switch(size)
            {
                case 0:
                    for (int i = 0; i < 4; i++)
                        Pawns.Add(FactoryPawn.INSTANCE.createPawn(this,r,m));
                    break;

                case 1:
                    for (int i = 0; i < 6; i++)
                        Pawns.Add(FactoryPawn.INSTANCE.createPawn(this, r,m));
                    break;

                case 2:
                    for (int i = 0; i < 8; i++)
                        Pawns.Add(FactoryPawn.INSTANCE.createPawn(this, r,m));
                    break;
            }
        }
    }
}