using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Map
    {
        //List de Tuiles repésentant la map.
        List<Tiles> Tiles { get; set; }

        //Ceci est un entier représentant la taille de la partie : 0=Demo, 1=Small, 2=Standard.
        int Size { get; set; }

        //Le type d'algo selon la taille de la map.
        FillAlgo PhilAlgo { get; set; }

        //Liste des positions de la map
        List<Position> positions { get; set; }

        Position SelectedPos { get; set; }

        //fonction permettant d'acceder à la tuile correspondant à la position donnée en paramètre.
        Tiles getTile(Position pos);

        List<Position> nextTo(Position p);

        //rempli la carte de tuiles avec le bon nobre de tuiles.
        void fillMap();

        //défini l'algorithme de remplissage suivant la taille de la map.
        void defAlgo(int size);
    }
}