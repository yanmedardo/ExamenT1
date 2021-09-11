using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenT1
{

    public class PlayerGame
    {

        public String Name;
        public CardsGame CardsGame = new CardsGame();


        public List<int> Cards = new List<int>();

        public void Dealcards()
        {

            for (int i = 0; i < 5; i++)
            {
                Cards.Add(CardsGame.Dealcards());

            }


        }
    }
}
