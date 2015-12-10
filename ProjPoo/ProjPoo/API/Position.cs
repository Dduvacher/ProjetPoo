using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Position
    {
        //abscisse de la position
        int PosX { get; set; }

        //ordonnée de la position
        int PosY { get; set; }

        //liste de pions présents sur cette position
        List<Pawn> Pawns { get; set; }


        //true si cette position est vide
        bool estVide();

        //true si pos est a coté de cette position
        bool nextTo(Position pos);


        //true si pos est a moins de 2 cases de cette position
        bool inRange(Position pos);

        //true si p peut bouger sur cette position
        bool canMove(Pawn p);

        //selectionne la pion avec la plus grosse défense sur cette position
        Pawn selectDefender();

        //permet de placer les pions sur la map lors de la création de la carte.
        bool putOn(Pawn p, Tiles t);
    }
}