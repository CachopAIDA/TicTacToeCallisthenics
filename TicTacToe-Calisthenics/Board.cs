using System;
using System.Collections.Generic;

namespace TicTacToe_Calisthenics
{
    public class Board
    {
        private class Cell
        {
            public virtual bool CheckPlayer ( string player )
            {
                return false;
            }

            public override String ToString ()
            {
                return String.Empty;
            }
        }


        private class CellX : Cell
        {
            public override bool CheckPlayer ( string player )
            {
                return player == "X";
            }

            public override String ToString ()
            {
                return "X";
            }
        }


        private class CellO : Cell
        {
            public override Boolean CheckPlayer ( String player )
            {
                return player == "O";
            }

            public override String ToString ()
            {
                return "O";
            }
        }

        private string[] board = new[] {
            String.Empty, String.Empty, String.Empty,
            String.Empty, String.Empty, String.Empty,
            String.Empty, String.Empty, String.Empty,
        };

        public IEnumerable<string> Render()
        {
            return board;
        }

        public void Mark(short position, string player)
        {
            if (!String.IsNullOrEmpty(this.board[position])) throw new InvalidOperationException();
            this.board[position] = player;
        }

        public bool CheckTicTacToe(string player)
        {
            return CheckHorizontals()  ||
                   CheckDiagonals() ;
        }

        private bool CheckHorizontals()
        {
            return !string.IsNullOrEmpty(board[0]) && board[0] == board[1] && board[0] == board[2] ||
                   !string.IsNullOrEmpty(board[3]) && board[3] == board[4] && board[4] == board[5] ||
                   !string.IsNullOrEmpty(board[6]) && board[6] == board[7] && board[7] == board[8];
        }

        private bool CheckDiagonals()
        {
            return !string.IsNullOrEmpty(board[4]) && board[4] == board[2] && board[2] == board[6] ||
                   !string.IsNullOrEmpty(board[0]) && board[0] == board[4] && board[4] == board[8];
        }
    }
}
