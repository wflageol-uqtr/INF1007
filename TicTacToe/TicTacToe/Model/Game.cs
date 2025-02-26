using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class Game
    {
        private Board board;
        private Player[] players;
        private Mark winner = Mark.None;

        public Player CurrentPlayer { get; private set; }

        public IEnumerable<Mark> GameState => board.BoardState;

        public Game()
        {
            players =
            [
                new Player(Mark.O),
                new Player(Mark.X)
            ];
            board = new Board();
            CurrentPlayer = players[0];
        }

        public void Play(int x, int y)
        {
            winner = board.PlaceMark(CurrentPlayer.Mark, x, y);
            CurrentPlayer = CurrentPlayer == players[0] ? players[1] : players[0];
        }
    }
}
