using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenT1
{
    public class CardsGame
    {

        public int Dealcards()
        {

            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = random.Next(1, 13);

            return value;
        }


    }
}
