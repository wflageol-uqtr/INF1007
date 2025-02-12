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

        public Mark PlaceMark(Mark m, int x, int y)
        {
            tiles[y * 3 + x] = m;

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
