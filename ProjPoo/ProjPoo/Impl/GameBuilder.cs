using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface GameBuildersuce
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

        public void addPlayer1(String name, Race race)
        {
            throw new System.NotImplementedException();
        }

        public void addPlayer2(String name, Race race)
        {
            throw new System.NotImplementedException();
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
            game.Turns = game.Mape.PhilAlgo.TURNS;

        }
    }
}