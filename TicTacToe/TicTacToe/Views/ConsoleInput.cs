using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Views
{
    public class ConsoleInput : IInput
    {
        public string? ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
