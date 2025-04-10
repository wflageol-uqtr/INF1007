using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Views;

namespace TicTacToeTests
{
    public class StringOutput : IOutput
    {
        private StringBuilder builder = new StringBuilder();

        public string Result => builder.ToString();
        public void Write(string text)
        {
            builder.Append(text);
        }
        public void WriteLine()
        {
            builder.AppendLine();
        }

        public void WriteLine(string line)
        {
            builder.AppendLine(line);
        }
    }
}
