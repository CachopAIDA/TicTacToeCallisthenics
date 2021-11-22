using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace TicTacToe_Calisthenics
{
    public class Board
    {
        private class Cell
        {
            public enum Line
            {
                HorizontalTop,
                HorizontalCenter,
                HorizontalBottom,
                VerticalLeft,
                VerticalCenter,
                VerticalRight,
                DiagonalLeft,
                DiagonalRight
            }

            private List<Line> lines;

            private string mark;

            public Cell(params Line[] lines)
            {
                this.mark = string.Empty;
                this.lines = lines.ToList();
            }

            public void Mark(string mark)
            {
                if (!String.IsNullOrEmpty(this.mark)) throw new InvalidOperationException();
                this.mark = mark;
            }

            public bool CheckPlayer ( string player )
            {
                return mark == player;
            }

            public override String ToString ()
            {
                return mark;
            }

            public bool IsInLine(Line line)
            {
                return this.lines.Contains(line);
            }
        }

        private readonly List<Cell> board;

        public Board()
        {
            board = new List<Cell>()
            {
                new Cell(Cell.Line.HorizontalTop, Cell.Line.VerticalLeft, Cell.Line.DiagonalLeft),
                new Cell(Cell.Line.HorizontalTop, Cell.Line.VerticalCenter),
                new Cell(Cell.Line.HorizontalTop, Cell.Line.VerticalRight, Cell.Line.DiagonalRight),
                new Cell(Cell.Line.HorizontalCenter, Cell.Line.VerticalLeft),
                new Cell(Cell.Line.HorizontalCenter, Cell.Line.VerticalCenter, Cell.Line.DiagonalLeft, Cell.Line.DiagonalRight),
                new Cell(Cell.Line.HorizontalCenter, Cell.Line.VerticalRight),
                new Cell(Cell.Line.HorizontalBottom, Cell.Line.VerticalLeft, Cell.Line.DiagonalRight),
                new Cell(Cell.Line.HorizontalBottom, Cell.Line.VerticalCenter),
                new Cell(Cell.Line.HorizontalBottom, Cell.Line.VerticalRight, Cell.Line.DiagonalLeft)
            };
        }

        public IEnumerable<string> Render()
        {
            return board.Select(cell => cell.ToString());
        }

        public void Mark(short position, string player)
        {
            this.board[position].Mark(player);
        }

        public bool CheckTicTacToe(string player)
        {
            return CheckHorizontals(player)  ||
                   CheckDiagonals(player) ;
        }

        private bool CheckHorizontals(string player)
        {
            return board.Count(cell => cell.CheckPlayer(player) && cell.IsInLine(Cell.Line.HorizontalTop)) == 3 ||
                   board.Count(cell => cell.CheckPlayer(player) && cell.IsInLine(Cell.Line.HorizontalCenter)) == 3 ||
                   board.Count(cell => cell.CheckPlayer(player) && cell.IsInLine(Cell.Line.HorizontalBottom)) == 3;
        }

        private bool CheckDiagonals(string player)
        {
            return board.Count(cell => cell.CheckPlayer(player) && cell.IsInLine(Cell.Line.DiagonalLeft)) == 3 ||
                   board.Count(cell => cell.CheckPlayer(player) && cell.IsInLine(Cell.Line.DiagonalRight)) == 3;
        }
    }
}
