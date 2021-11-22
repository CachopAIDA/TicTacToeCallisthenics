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

            private bool CheckPlayer ( string player )
            {
                return mark == player;
            }

            public override String ToString ()
            {
                return mark;
            }

            private bool IsInLine(Line line)
            {
                return this.lines.Contains(line);
            }

            public bool CheckPlayerInLine(string player, Line line)
            {
                return CheckPlayer(player) && IsInLine(line);
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
            foreach (Cell.Line cellLine in Enum.GetValues(typeof(Cell.Line)))
            {
                if (board.Count(cell => cell.CheckPlayerInLine(player, cellLine)) == 3)
                    return true;
            }

            return false;
        }

    }
}
