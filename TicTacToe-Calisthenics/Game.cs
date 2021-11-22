using System;
using System.Collections.Generic;
using Xunit.Sdk;

namespace TicTacToe_Calisthenics
{
    public class Game
    {
        private Player player = Player.player1;
        private readonly Board board = new Board();

        private enum Player
        {
            player1 = 'X',
            player2 = 'O'
        }

        public IEnumerable<string> Render()
        {
            return board.Render();
        }

        public void Play(short position)
        {
            board.Mark(position, ((char)player).ToString());
            ChangePlayer();
        }

        private void ChangePlayer()
        {
            player = player == Player.player1 ? Player.player2 : Player.player1;
        }

        internal string Winner()
        {
            return ((char)(player == Player.player1 ? Player.player2 : Player.player1)).ToString();
        }
    }
}