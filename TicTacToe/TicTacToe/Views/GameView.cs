using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Model;

namespace TicTacToe.Views
{
    public class GameView
    {
        public void PrintGame(Game game)
        {
            var boardState = game.GameState;

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    char c;
                    switch(boardState.ElementAt(y * 3 + x))
                    {
                        case Mark.O:
                            c = 'o';
                            break;
                        case Mark.X:
                            c = 'x';
                            break;
                        default:
                            c = '_';
                            break;
                    }
                    Console.Write("{0} ", c);
                }
                Console.WriteLine();
            }
        }

        public (int, int)? PrintPlay(Game game)
        {
            Console.Write("Player {0} move: ", game.CurrentPlayer.Mark);
            Console.WriteLine();

            return ReadPlay();
        }

        private (int, int)? ReadPlay()
        {
            var coord = Console.ReadLine();
            if (string.IsNullOrEmpty(coord))
                return null;
            else
            {
                var splittedCoord = coord.Split(',');
                int x = int.Parse(splittedCoord[0]);
                int y = int.Parse(splittedCoord[1]);
                return (x, y);
            }
        }
    }
}