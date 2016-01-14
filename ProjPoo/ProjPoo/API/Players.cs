using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Player
    {
        //pions du joueur
        List<Pawn> Pawns { get; set; }

        //pseudo du joueur
        string Pseudo { get; set; }
        //race du joueur
        Race Race { get; set; }


        int Point { get; set; }
        int Order { get; set; }

        //true si c'est le tour de ce joueur
        bool isTurn { get; set; }

        //rempli la list de pion du joueur en fonction de sa race
        void addPawns(int size,Race r,Map m);
    }
}