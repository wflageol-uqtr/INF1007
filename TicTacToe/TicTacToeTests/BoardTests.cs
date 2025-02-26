using TicTacToe.Model;

namespace TicTacToeTests
{
    [TestClass]
    public class BoardTests
    {
        private Board board;

        [TestInitialize]
        public void Setup()
        {
            board = new Board();
        }

        [TestMethod]
        public void TestPlaceMark()
        {
            // Arrange & Act
            board.PlaceMark(Mark.O, 1, 1);
            var boardState = board.BoardState;

            // Assert
            Assert.AreEqual(Mark.O, boardState.ElementAt(4));
        }

        [DataTestMethod]
        [DataRow(-1, 0)]
        [DataRow(3, 0)]
        [DataRow(0, -1)]
        [DataRow(0, 3)]
        public void TestPlaceMarkInvalid(int x, int y)
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(
                () => board.PlaceMark(Mark.O, x, y));
        }

        [TestMethod]
        public void TestPlaceExistingMark()
        {
            // Arrange
            board.PlaceMark(Mark.O, 1, 1);

            // Act & Assert
            //try
            //{
            //    board.PlaceMark(Mark.X, 1, 1);

            //    Assert.Fail();
            //} catch(ArgumentException)
            //{
            //    // OK.
            //}

            Assert.ThrowsException<ArgumentException>(() =>
            {
                board.PlaceMark(Mark.X, 1, 1);
            });
        }
    }
}