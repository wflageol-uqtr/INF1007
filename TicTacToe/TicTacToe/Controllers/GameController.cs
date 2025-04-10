using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Model;
using TicTacToe.Views;

namespace TicTacToe.Controllers
{
    public class GameController
    {
        private Game game;
        private IGameView view;

        public GameController()
        {
            game = new Game();
            view = new GameView(new ConsoleInput(), new ConsoleOutput());
        }

        public void PlayGame()
        {
            while (true) {
                view.PrintGame(game);
                var coord = view.PrintPlay(game);

                if (coord == null)
                    return;
                else
                {
                    (int x, int y) = coord.Value;
                    game.Play(x, y);
                }
            }
        }
    }
}
 