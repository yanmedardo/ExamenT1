using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using ExamenT1;

namespace ExamenT1.Tests
{
    class PokerGame
    {
        public void Case001()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame{ Name ="Player 1"});
            Game.AddPlayer(new PlayerGame { Name = "Player 2"});
            Assert.Trows(typeof(Exception), () => game.PlayeGame());
        }

        public void Case002()
        {
            var Game = new PokerGame();
            Game.AddPlayer(new PlayerGame { Name = "Player 1" });
            Game.AddPlayer(new PlayerGame { Name = "Player 2" });
            Game.AddPlayer(new PlayerGame { Name = "Player 3" });

            Assert.Trows(typeof(Exception), () => game.PlayeGame());
        }


    }
}
