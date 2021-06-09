using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schach2
{
    public  class Figur
    {
        public char Name { get; set; }
        public int Farbe { get; set; } // 0 = schwarz, 1 = weiß
        public string Darstellung { get; set; }
        public bool EnPassentAble { get; set; } = false;
        public int Moves { get; set; } = 0;


        /// <summary>
        /// Create a chess piece.
        /// </summary>
        /// <param name="name">'b'-> bishop, 'n' -> knight, 'k' -> king usw.</param>
        /// <param name="farbeInt"> 0 = black, 1 = white</param>
        public Figur(char name, int farbeInt)
        {
            Name = char.ToUpper(name);
            Farbe = farbeInt ;

            // b = 98
            // k = 107
            // n = 110
            // p = 112
            // q = 113
            // r = 114
            List<string> figuren = new List<string>();
            figuren.Add("♗");
            figuren.Add("♝");
            figuren.Add("♔");
            figuren.Add("♚");
            figuren.Add("♘");
            figuren.Add("♞");
            figuren.Add("♙");
            figuren.Add("♟");
            figuren.Add("♕");
            figuren.Add("♛");
            figuren.Add("♖");
            figuren.Add("♜");


            if (name == 98)
            {
                Darstellung = farbeInt == 1 ? figuren.ElementAt(0) : figuren.ElementAt(1);
            }
            if (name == 107)
            {
                Darstellung = farbeInt == 1 ? figuren.ElementAt(2) : figuren.ElementAt(3);
            }
            if (name == 110)
            {
                Darstellung = farbeInt == 1 ? figuren.ElementAt(4) : figuren.ElementAt(5);
            }
            if (name == 112)
            {
                Darstellung = farbeInt == 1 ? figuren.ElementAt(6) : figuren.ElementAt(7);
            }
            if (name == 113)
            {
                Darstellung = farbeInt == 1 ? figuren.ElementAt(8) : figuren.ElementAt(9);
            }
            if (name == 114)
            {
                Darstellung = farbeInt == 1 ? figuren.ElementAt(10) : figuren.ElementAt(11);
            }
              
        }
    }
}
