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
        private Player player1, player2;
        private Game game;
        private Map map;

        public void addPlayer1(Player p)
        {
            game.Player1 = p;
        }

        public void addPlayer2(Player p)
        {
            game.Player2 = p;
        }

        public GameImpl createGame()
        {
            return new GameImpl();
        }

        public MapImpl createMap(int size,Game game)
        {
            MapImpl maap = new MapImpl(size);
            maap.fillMap();
            game.Mape=maap;
            return maap;
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
            addPlayer1(player1);
            addPlayer2(player2);
        }
    }
}