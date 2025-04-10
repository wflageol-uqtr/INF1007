using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Model;
using TicTacToe.Views;

namespace TicTacToeTests
{
    [TestClass]
    public class GameViewTests
    {
        private GameView view;
        private StringInput input;
        private StringOutput output;

        [TestInitialize]
        public void Setup()
        {
            input = new StringInput("");
            output = new StringOutput();

            view = new GameView(input, output);
        }

        [TestMethod]
        public void TestInitialGameView()
        {
            // Arrange
            var game = new Game();

            // Act
            view.PrintGame(game);

            // Assert
            StringAssert.Contains(output.Result, "_ _ _");
        }
    }
}
