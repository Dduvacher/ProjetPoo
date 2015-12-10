using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface GameBuilderInt
    {
        void addPlayer1(String name, Race race);
        void createGame();
        void addPlayer2();
    }

    public class GameBuilder
    {
        private int size;
        private string player1FName, player2FName, player1LName, player2LName;
        private Race race;
        private Game game;
        private Map map;

        public void addPlayer1(string LastName, string FirstName,Race r)
        {
            game.Player1 = new PlayerImpl(LastName,FirstName,r);
            game.Player1.addPawns(size, game.Player1.Race,game.Mape);
        }

        public void addPlayer2(string LastName, string FirstName, Race r)
        {
            game.Player1 = new PlayerImpl(LastName, FirstName, r);
            game.Player1.addPawns(size, game.Player1.Race,game.Mape);
        }

        public GameImpl createGame()
        {
            return new GameImpl();
        }

        public Map createMap(int size,Game game)
        {
            Map maap = FactoryMap.INSTANCE.createMap(size);
            maap.fillMap();
            game.Mape=maap;
            return maap;
        }

        public void chooseFirstPlayer()
        {
            Random r = new Random();
            int i = r.Next(1);
            if (i == 0)
                game.Player1.isTurn = true;
            else game.Player2.isTurn = true;
        }

        public void putUnits()
        {
            int i = 0;
            int j = 0;
            Map map = game.Mape;
            Position pos;
            foreach (Pawn p in game.Player1.Pawns)
            {
                pos = map.positions[i];
                pos.putOn(p, map.getTile(pos));
                i++;
            }

            foreach (Pawn p in game.Player1.Pawns)
            {
                pos = map.positions[map.positions.Count-j];
                pos.putOn(p, map.getTile(pos));
                j++;
            }
        }

        public void loadGame(Game game)
        {
            throw new System.NotImplementedException();
        }

        public void build()
        {
            game = createGame();
            map = createMap(size, game);
            game.Turns = game.Mape.PhilAlgo.Turns;
            game.Units = game.Mape.PhilAlgo.Units;
            addPlayer1(player1LName,player1FName,race);
            addPlayer2(player2LName, player2FName, race);
            chooseFirstPlayer();
            putUnits();
        }
    }
}