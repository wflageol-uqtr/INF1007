using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Model;

namespace TicTacToe.Views
{
    public class GameView : IGameView
    {
        private IOutput output;
        private IInput input;

        public GameView(IInput input, IOutput output)
        {
            this.input = input;
            this.output = output;
        }

        public void PrintGame(Game game)
        {
            var boardState = game.GameState;

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    char c;
                    switch (boardState.ElementAt(y * 3 + x))
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
                    output.Write(string.Format("{0} ", c));
                }
                output.WriteLine();
            }
        }

        public (int, int)? PrintPlay(Game game)
        {
            output.Write(string.Format("Player {0} move: ", game.CurrentPlayer.Mark));
            output.WriteLine();

            return ReadPlay();
        }

        private (int, int)? ReadPlay()
        {
            var coord = input.ReadLine();
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