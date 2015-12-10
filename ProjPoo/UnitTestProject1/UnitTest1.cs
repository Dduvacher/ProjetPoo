using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjPoo;
using System.Collections.Generic;



namespace UnitTest_ProjPoo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNomJoueur()
        {
            GameBuilder g = new GameBuilder();
            g.addsize(0);
            g.player1FName="Florentin";
            g.player2FName = "Damien";
            g.player1LName = "Hortet";
            g.player2LName = "Duvacher";
            g.race1 = FactoryRace.INSTANCE.getOrc();
            g.race2 = FactoryRace.INSTANCE.getHuman();
            g.build();
            //GameImpl Game = g.createGame();

            //g.createMap(0, Game);
            //g.addPlayer1("Hortet", "Florentin", FactoryRace.INSTANCE.getOrc());
            //g.addPlayer2("Duvacher", "Damien", FactoryRace.INSTANCE.getElf());


            Assert.AreEqual("Hortet", g.game.Player1.LastName);
            Assert.AreEqual("Damien", g.game.Player2.FirstName);
        }
    }
}
