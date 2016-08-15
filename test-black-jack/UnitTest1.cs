using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using games_common.Enums;
using games_common.Interfaces;
using black_jack.Models;

namespace test_black_jack {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            //test deck creation
            var deck = new FrenchDeck();
            deck.Shuffle();

            //creating cards for hands
            var h1 = new List<ICard>() { new FrenchCard(FrenchCardName.Jack, FrenchSuit.Spade),
                new FrenchCard(FrenchCardName.Seven, FrenchSuit.Diamond) };
            var h2 = new List<ICard>() { new FrenchCard(FrenchCardName.Two, FrenchSuit.Spade),
                new FrenchCard(FrenchCardName.Two, FrenchSuit.Diamond), new FrenchCard(FrenchCardName.Two, FrenchSuit.Heart),
                new FrenchCard(FrenchCardName.Four, FrenchSuit.Diamond), new FrenchCard(FrenchCardName.Five, FrenchSuit.Club) };
            var h3 = new List<ICard>() { new FrenchCard(FrenchCardName.King, FrenchSuit.Diamond),
                new FrenchCard(FrenchCardName.Four, FrenchSuit.Spade), new FrenchCard(FrenchCardName.Four, FrenchSuit.Club) };
            var h4 = new List<ICard>() { new FrenchCard(FrenchCardName.Queen, FrenchSuit.Club),
                new FrenchCard(FrenchCardName.Six, FrenchSuit.Spade), new FrenchCard(FrenchCardName.Nine, FrenchSuit.Diamond) };

            //players with ahnds
            var p1 = new Player("Dealer", true, new Hand(h1));
            var p2 = new Player("Billy", false, new Hand(h2));
            var p3 = new Player("Andrew", false, new Hand(h3));
            var p4 = new Player("Carla", false, new Hand(h4));
        }
    }
}
