using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public class FactoryPawn
    {

        public static FactoryPawn INSTANCE = new FactoryPawn();
        public Pawn createPawn(Player p, Race r)
        {
            return new PawnImpl(p, r);
        }
    }
}