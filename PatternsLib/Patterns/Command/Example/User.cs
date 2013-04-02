using System;
using System.Collections.Generic;

namespace PatternsLib.Patterns.Command.Example
{
    public class User
    {
        // Initializers
        private Calculator _calculator = new Calculator();
        private List<Command> _commands = new List<Command>();

        private int _current = 0;

        public string Redo(int levels)
        {

            var result = "";
            // Делаем возврат операций
            for (int i = 0; i < levels; i++)
                if (_current < _commands.Count - 1)
                    result += _commands[_current++].Execute() + "\n";

            return "\n---- Redo " + levels + " levels "+result;
        }

        public string Undo(int levels)
        {

            var result = "";
            // Делаем отмену операций
            for (int i = 0; i < levels; i++)
                if (_current > 0)
                    result += _commands[--_current].UnExecute() + "\n";


            return "\n---- Undo " + levels + " levels "+result; 
        }

        public string Compute(char @operator, int operand)
        {

            // Создаем команду операции и выполняем её
            Command command = new CalculatorCommand(
                _calculator, @operator, operand);
            var result = command.Execute();

            // Добавляем операцию к списку отмены
            _commands.Add(command);
            _current++;
            return result;
        }
    }
}