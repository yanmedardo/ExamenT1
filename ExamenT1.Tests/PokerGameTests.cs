using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ExamenT1.Tests
{
    class PokerGameTest
    {
    
        [Test]
        public void Case001()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame{ Name ="Player 1"});
            Game.AddPlayer(new PlayerGame { Name = "Player 2"});
            Assert.Throws(typeof(Exception), () => Game.PlayeGame());
        }
        [Test]
        public void Case002()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });
            Game.AddPlayer(new PlayerGame { Name = "Player 3" });

            Assert.Throws(typeof(Exception), () => Game.PlayeGame());
        }
        [Test]
        public void Case003()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });
            Game.AddPlayer(new PlayerGame { Name = "Player 3" });
            Game.AddPlayer(new PlayerGame { Name = "Player 4" });

            Assert.Throws(typeof(Exception), () => Game.PlayeGame());
        }
        [Test]
        public void Case004()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });
            Game.AddPlayer(new PlayerGame { Name = "Player 3" });
            Game.AddPlayer(new PlayerGame { Name = "Player 4" });
            Game.AddPlayer(new PlayerGame { Name = "Player 4" });

            Assert.Throws(typeof(Exception), () => Game.PlayeGame());
        }
        [Test]
        public void Case005()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });
            Game.AddPlayer(new PlayerGame { Name = "Player 3" });
            Game.AddPlayer(new PlayerGame { Name = "Player 4" });
            Game.AddPlayer(new PlayerGame { Name = "Player 4" });

            Assert.Throws(typeof(Exception), () => Game.PlayeGame());

        }
        [Test]
        public void Case006()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });
            Game.AddPlayer(new PlayerGame { Name = "Player 3" });
            Game.AddPlayer(new PlayerGame { Name = "Player 4" });
            Game.AddPlayer(new PlayerGame { Name = "Player 4" });

            Assert.Throws(typeof(Exception), () => Game.PlayeGame());

        }

        [Test]
        public void Case007()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });
            Game.AddPlayer(new PlayerGame { Name = "Player 3" });
            Game.AddPlayer(new PlayerGame { Name = "Player 4" });
            Game.AddPlayer(new PlayerGame { Name = "Player 4" });

            Assert.Throws(typeof(Exception), () => Game.PlayeGame());
            Game.Dealcards();
        }
        
        [Test]
        public void Case008()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });

            Game.Dealcards();
            var Player = Game.players.ElementAt(0); 
            Assert.AreEqual(5, Player.Cards.Count);
        
           }

        [Test]
        public void Case008()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });

            Game.Dealcards();
            var Player = Game.players.ElementAt(0);
            Assert.AreEqual(5, Player.Cards.Count);

        }
        [Test]
        public void Case009()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });

            Game.Dealcards();
            var Player = Game.players.ElementAt(0);
                   Assert.AreEqual(5, Player.Cards.Count);
            Assert.AreEqual("Trebol", Player.Cards.ElementAt(0));
          

        }
        public void Case0010()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });

            Game.Dealcards();
            var Player = Game.players.ElementAt(0);
            Assert.AreEqual(5, Player.Cards.Count);
         
            Assert.AreEqual("Rombo", Player.Cards.ElementAt(0));

        }
        public void Case0011    ()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });

            Game.Dealcards();
            var Player = Game.players.ElementAt(0);
            Assert.AreEqual(5, Player.Cards.Count);

            Assert.AreEqual("Picas", Player.Cards.ElementAt(0));

        }
        public void Case0012()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });

            Game.Dealcards();
            var Player = Game.players.ElementAt(0);
            Assert.AreEqual(5, Player.Cards.Count);

            Assert.AreEqual("Corazones ", Player.Cards.ElementAt(0));

        }

        public void Case0013()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });

            Game.Dealcards();
            var Player = Game.players.ElementAt(0);
            Assert.AreEqual(5, Player.Cards.Count);

            Assert.AreEqual("Corazones ", Player.Cards.ElementAt(0));
            Assert.AreEqual("Picas ", Player.Cards.ElementAt(1));

        }
        public void Case0014()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });

            Game.Dealcards();
            var Player = Game.players.ElementAt(0);
            Assert.AreEqual(5, Player.Cards.Count);

            Assert.AreEqual("Treboles ", Player.Cards.ElementAt(0));
            Assert.AreEqual("Picas ", Player.Cards.ElementAt(1));

        }







    }
}
