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

        public int Turns
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

        public int Units
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

        public Player Player2
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

        public Player Player1
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
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }


        public GameImpl()
        {
            Ended = false;
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