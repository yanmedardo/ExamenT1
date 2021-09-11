using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;



namespace ExamenT1.Tests
{
    class PokerGameTests
    {
        public void Case001()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame{ Name ="Player 1"});
            Game.AddPlayer(new PlayerGame { Name = "Player 2"});
            Assert.Throws(typeof(Exception), () => Game.PlayeGame());
        }

        public void Case002()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });
            Game.AddPlayer(new PlayerGame { Name = "Player 3" });

            Assert.Throws(typeof(Exception), () => Game.PlayeGame());
        }
        public void Case003()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });
            Game.AddPlayer(new PlayerGame { Name = "Player 3" });
            Game.AddPlayer(new PlayerGame { Name = "Player 4" });

            Assert.Throws(typeof(Exception), () => Game.PlayeGame());
        }

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



    }
}
