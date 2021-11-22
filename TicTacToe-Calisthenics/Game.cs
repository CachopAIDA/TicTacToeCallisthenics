using System;
using System.Collections.Generic;
using Xunit.Sdk;

namespace TicTacToe_Calisthenics
{
    public class Game
    {
        private string player = "X";
        private readonly Board board = new Board();

        private enum Player
        {
            playerX = 'X',
            playerO = 'O'
        }

        public IEnumerable<string> Render()
        {
            return board.Render();
        }

        public void Play(short position)
        {
            board.Mark(position, player);
            ChangePlayer();
        }

        private void ChangePlayer()
        {
            player = player == "X" ? "O" : "X";
        }

        internal string Winner()
        {
            return player == "X" ? "O" : "X";
        }
    }
}