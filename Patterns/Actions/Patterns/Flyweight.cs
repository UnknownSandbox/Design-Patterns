using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLib.Patterns.Flyweight.Example;

namespace Patterns.Actions.Patterns
{
    class Flyweight : PatternAction
    {
        public override void Execute()
        {
            // Build a document with text
            const string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            var f = new CharacterFactory();

            // extrinsic state
            var pointSize = 10;

            // For each character use a flyweight object
            foreach (var c in chars)
            {
                pointSize++;
                var character = f.GetCharacter(c);
                Console.WriteLine(character.Display(pointSize));
            }

            _again();
        }
    }
}
