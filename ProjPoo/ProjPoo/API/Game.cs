using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Game
    {
        //Les 2 joueurs de la partie
        Player Player2 { get; set; }
        Player Player1 { get; set; }

        //La carte de la partie
        Map Mape { get; set; }

        //nombre d'unités pour cette partie
        int Units { get; set; }

        //nombre de tours pour cette partie
        int Turns { get; set; }


        void setTurns(int nbTurns);
        void setUnits(int nbUnits);

        //Met fin au tour du joueur courant.
        void endTurn();

        //Appelé quand un joueur gagne la partie.
        void endGame(Player p);
        Player winner();
        void enregister();
        void game_is_over();
    }
}