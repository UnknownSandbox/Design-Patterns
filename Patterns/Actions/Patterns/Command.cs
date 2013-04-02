using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLib.Patterns.Command.Example;

namespace Patterns.Actions.Patterns
{
    class Command : PatternAction
    {
        public override void Execute()
        {
            // Создаем пользователя.
            var user = new User();

            // Пусть он что-нибудь сделает.
            Console.WriteLine(user.Compute('+', 100));
            Console.WriteLine(user.Compute('-', 50));
            Console.WriteLine(user.Compute('*', 10));
            Console.WriteLine(user.Compute('/', 2));

            // Отменяем 4 команды
            Console.WriteLine(user.Undo(4));

            // Вернём 3 отменённые команды.
            Console.WriteLine(user.Redo(3));

            // Ждем ввода пользователя и завершаемся.
            _again();
        }
    }
}
