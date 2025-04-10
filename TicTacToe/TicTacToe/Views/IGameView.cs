using TicTacToe.Model;

namespace TicTacToe.Views
{
    public interface IGameView
    {
        void PrintGame(Game game);
        (int, int)? PrintPlay(Game game);
    }
}