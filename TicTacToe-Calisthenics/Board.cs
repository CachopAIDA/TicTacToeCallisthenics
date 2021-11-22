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
    }
}