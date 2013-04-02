using System;

namespace PatternsLib.Patterns.Command.Example
{
    public class Calculator
    {
        private int curr = 0;

        public string Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': curr += operand; break;
                case '-': curr -= operand; break;
                case '*': curr *= operand; break;
                case '/': curr /= operand; break;
            }
             
            return "Current value = " + curr + " (following " + @operator + " " + operand + ")";
        }
    }
}