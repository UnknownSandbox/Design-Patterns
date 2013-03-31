using System.Collections;

namespace PatternsLib.Patterns.Flyweight.Example
{
    public class CharacterFactory
    {
        private Hashtable characters = new Hashtable();

        public Character GetCharacter(char key)
        {
            // Uses "lazy initialization"
            var character = characters[key] as Character;

            if (character == null)
            {
                switch (key)
                {
                    case 'A': character = new CharacterA(); break;
                    case 'B': character = new CharacterB(); break;
                        //...
                    case 'Z': character = new CharacterZ(); break;
                }
                characters.Add(key, character);
            }
            return character;
        }
    }
}