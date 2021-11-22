using System;
using System.Collections.Generic;
using System.Linq;
using Xunit.Sdk;


namespace TicTacToe_Calisthenics
{
    internal sealed class Game
    {
        private          Player player = Player.X;
        private readonly Board  board  = new Board();


        private sealed class Player
        {
            private readonly string id;

            public static Player X = new Player ( "X" );
            public static Player O = new Player( "O" );

            private Player ( string id )
            {
                this.id = id;
            }

            public override String ToString () => this.id;
        }


        internal IEnumerable<string> Render ()
        {
            return board.Render();
        }

        internal void Play ( short position )
        {
            board.Mark( position, player.ToString() );
            ChangePlayer();
        }

        private void ChangePlayer ()
        {
            player =
                    player == Player.X
                            ? Player.O
                            : Player.X;
        }

        internal string Winner ()
        {
            if (board.Render().
                Count(cell => cell != string.Empty) < 5) 
                return string.Empty;
            if (board.Render().
                Count(cell => cell != string.Empty) == 9)
                return string.Empty;
            return player == Player.X
                    ? Player.O.ToString()
                    : Player.X.ToString();
        }
    }
}
