using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    //représente les pions des joueurs.
    public interface Pawn
    {
        //le joueur a qui appartient ce pion
        Player player { get; set; }

        //race de ce pion
        Race race { get; set; }

        //position de ce pion
        Position position { get; set; }

        //points de mouvement actuels de ce pion
        double MovePoint { get; set; }

        //points de vie actuels de ce pion
        int lifePoint { get; set; }

        //la carte dans lequel se déplace ce pion
        Map map { get; set; }

        //rend l'attaque de ce pion, l'attaque est calculé proportionellement au point de vie restant
        double getAttack();

        //rend la défense de ce pion, l'attaque est calculé proportionellement au point de vie restant
        double getDefence();

        //attaque une position
        void attack_action(Position pos);

        //bouge sur une position
        void move_action(Position pos);
    }
}