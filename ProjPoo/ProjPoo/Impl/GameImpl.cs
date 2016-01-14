using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public class GameImpl : Game
    {
        private Player player1;
        private Player player2;
        private Map map;

        private int turns;
        private int units;
        private bool ended;


        public int Turns
        {
            get
            {
                return turns;
            }

            set
            {
                turns = value;
            }
        }

        public int Units
        {
            get
            {
                return units;
            }

            set
            {
                units = value;
            }
        }

        public Player Player2
        {
            get
            {
                return player2;
            }

            set
            {
                player2 = value;
            }
        }

        public Player Player1
        {
            get
            {
                return player1;
            }

            set
            {
                player1 = value;
            }
        }

        public Map Mape
        {
            get
            {
                return map;
            }

            set
            {
                map = value;
            }
        }

        public bool Ended
        {
            get
            {
                return ended;
            }

            set
            {
                ended = value;
            }
        }


        public GameImpl()
        {
            ended = false;
        }
        public void setTurns(int nbTurns)
        {
            throw new NotImplementedException();
        }

        public void setUnits(int nbUnits)
        {
            throw new NotImplementedException();
        }

        public void endTurn()
        {
            if (this.Player1.Pawns.Count == 0)
                this.endGame(Player2);
            else if (this.Player2.Pawns.Count == 0)
                this.endGame(Player1);

            if (this.Player2.isTurn)
            {
                this.Player2.isTurn = false;
                this.Player1.isTurn = true;
            }
            else
            {
                this.Player2.isTurn = true;
                this.Player1.isTurn = false;
            }
        }

        public void endGame(Player p)
        {
            throw new NotImplementedException();
        }

        void Game.game_is_over()
        {
            throw new NotImplementedException();
        }

        public Player winner()
        {
            throw new NotImplementedException();
        }

        public void enregister()
        {
            throw new NotImplementedException();
        }
    }
}