using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Game
    {
        Player Player2 { get; set; }
        Player Player1 { get; set; }
        Map Mape { get; set; }
        int Units { get; set; }
        int Turns { get; set; }


        void setTurns(int nbTurns);
        void setUnits(int nbUnits);
        void endTurn();
        void endGame(Player p);
        Player winner();
        void enregister();
        void game_is_over();
    }
}