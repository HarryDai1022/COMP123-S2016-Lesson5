using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /**
     * This class creates an object 
     * 
     * @class Card
     * 
     */
    public class Card
    {
        // public properties
        public int Face { get; set; }
        public string Suit { get; set; }

        /**
         * This constructor takes two parameters: Face and Suit to instantiate a Card project
         * 
         * @constructor Card
         * @param {int} face
         * @param {string} suit
         */
        public Card(int face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
