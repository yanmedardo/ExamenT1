using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenT1
{
    public class PokerGame
    {
        public List<PlayerGame> players = new List<PlayerGame>();   
        public void AddPlayer (PlayerGame  playerGame)
        {

            players.Add(playerGame);

        }
        public void PlayeGame()
        {

        }
        public void Dealcards()
        {
            foreach (var Player in players)
            {
                Player.Dealcards();
            }
        }
    }

    
}
