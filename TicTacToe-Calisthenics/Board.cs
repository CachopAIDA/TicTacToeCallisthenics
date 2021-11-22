using System;
using System.Collections.Generic;

namespace TicTacToe_Calisthenics
{
    public class Board
    {
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
            return !string.IsNullOrEmpty(board[0]) && board[0] == board[1] && board[0] == board[2] ||
                   !string.IsNullOrEmpty(board[3]) && board[3] == board[4] && board[4] == board[5] ||
                   !string.IsNullOrEmpty(board[6]) && board[6] == board[7] && board[7] == board[8] ||
                   !string.IsNullOrEmpty(board[0]) && board[0] == board[4] && board[4] == board[8];
        }

    }
}