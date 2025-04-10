using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Views;

namespace TicTacToeTests
{
    public class StringInput : IInput
    {
        private string input;

        public StringInput(string input)
        {
            this.input = input;
        }

        public string? ReadLine()
        {
            return input;
        }
    }
}
