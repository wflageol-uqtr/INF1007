using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class Board
    {
        private Mark[] tiles;

        public IEnumerable<Mark> BoardState => tiles;

        public Board()
        {
            tiles = [
                Mark.None,
                Mark.None,
                Mark.None,
                Mark.None,
                Mark.None,
                Mark.None,
                Mark.None,
                Mark.None,
                Mark.None,
            ];
        }

        public Board(IEnumerable<Mark> tiles)
        {
            this.tiles = tiles.ToArray();
        }

        /// <summary>
        /// Place un jeton à l'endroit spécifié par x et y.
        /// </summary>
        /// <param name="m">Le type de jeton.</param>
        /// <param name="x">La coordonnée x de 0 à 2.</param>
        /// <param name="y">La coordonnées y de 0 à 2.</param>
        /// <returns>Retourne None si aucun joueur n'a gagné. 
        /// Sinon retourne le jeton du joueur gagnant.</returns>
        public Mark PlaceMark(Mark m, int x, int y)
        {
            if (x < 0 || x > 2 || y < 0 || y > 2)
                throw new ArgumentException("Invalid coordinates.");

            int n = y * 3 + x;

            if (tiles[n] != Mark.None)
                throw new ArgumentException("Tiles already marked.");

            tiles[n] = m;

            return HasWon();
        }

        private bool WinCombo(Mark m1, Mark m2, Mark m3)
        {
            return m1 != Mark.None && m1 == m2 && m2 == m3;
        }

        private Mark HasWon()
        {
            Mark[][] lines = [
                [tiles[0], tiles[1], tiles[2]],
                [tiles[3], tiles[4], tiles[5]],
                [tiles[6], tiles[7], tiles[8]],
                [tiles[0], tiles[3], tiles[6]],
                [tiles[1], tiles[4], tiles[7]],
                [tiles[2], tiles[5], tiles[8]],
                [tiles[0], tiles[4], tiles[8]],
                [tiles[2], tiles[4], tiles[6]],
            ];

            foreach(var line in lines)
            {
                if (WinCombo(line[0], line[1], line[2]))
                    return line[0];
            }

            return Mark.None;
        }
    }
}
