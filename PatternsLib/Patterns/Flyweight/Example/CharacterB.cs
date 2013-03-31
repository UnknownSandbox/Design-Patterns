using System;

namespace PatternsLib.Patterns.Flyweight.Example
{
    public class CharacterB : Character
    {
        // Constructor
        public CharacterB()
        {
            this.symbol = 'B';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }

        public override string Display(int pointSize)
        {
            this.pointSize = pointSize;
            return  this.symbol + " (pointsize " + this.pointSize + ")";
        }

    }
}