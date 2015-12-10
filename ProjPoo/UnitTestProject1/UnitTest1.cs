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
            GameImpl Game = g.createGame();
            g.createMap(0, Game);
            g.addPlayer1("Hortet", "Florentin", FactoryRace.INSTANCE.getOrc());
            g.addPlayer2("Duvacher", "Damien", FactoryRace.INSTANCE.getElf());

            Assert.AreEqual("Hortet",g.)
        }
    }
}
