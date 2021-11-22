using System;
using System.Collections.Generic;
using Xunit.Sdk;

namespace TicTacToe_Calisthenics
{
    public class Game
    {
        private string[] board = new string[] {
            String.Empty, String.Empty, String.Empty,
            String.Empty, String.Empty, String.Empty,
            String.Empty, String.Empty, String.Empty,
        };

        private string player = "X";

        public IEnumerable<string> Render()
        {
            return board;
        }

        public void Play(short position)
        {
            if (!String.IsNullOrEmpty(board[position])) throw new InvalidOperationException();
            board[position] = player;
            ChangePlayer();
        }

        private void ChangePlayer()
        {
            player = player == "X" ? "O" : "X";
        }
    }
}