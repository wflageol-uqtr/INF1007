using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Views
{
    public interface IOutput
    {
        void WriteLine();
        void WriteLine(string line);
        void Write(string text);
    }
}
