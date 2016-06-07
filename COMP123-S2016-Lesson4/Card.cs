using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
   public class Card
    {
        private int Face { get; set; }
        private string Suit { get; set; }

       public Card(int face , string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
