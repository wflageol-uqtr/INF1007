using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class Player
    {
        private int wins = 0;
        public Mark Mark { get; }

        public Player(Mark mark)
        {
            Mark = mark;
        }
    }
}
